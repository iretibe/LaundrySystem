
$(document).ready(function () {
    $("#cboProduct").change(function () {
        //$.ajax({
        //    async: true,
        //    type: 'GET',
        //    dataType: 'JSON',
        //    contentType: 'application/json; charset-utf-8',
        //    data: { ProductID: ProductID },
        //    url: '/product/GetProductUnitPrice',
        //    success: function (data) {
        //        $("#txtUnitPrice").val(parseFloat(data).toFixed(2));
        //    },
        //    error: function () {
        //        alert("An error occurred getting the Unit Price! Please contact your administrator");
        //    }
        //});
        alert($("#cboProduct").val());
        var ProductID = $("#cboProduct").val();
        alert(ProductID);
        var url = "/data/GetUnitPriceByProductId?ProductID=" + ProductID;
        alert(url);
        let options = "<option value='-1' selected>Select Product </option>";
        $.get(url, function (data, status) {
            //$(data).each(function (i, val) {
            //    options += "<option value='" + val.packageID + "'>" + val.packageName + "</option>";
            //});
            //$('#cboPackage').html(options);

            $("#txtUnitPrice").val(data[0].productPrice);
        });

        //let url = "/ProductPrice/GetUnitPriceByProductPackageIDAndProductID/" + $("#cboProduct").val() + "/" + $("#cboPackage").val();
        //$.get(url, function (data, status) {
        //    $("#txtSellingPrice").val(data[0].sellingPriceWithTAX);
        //});
    });
});

$(document).ready(function () {
    $("#txtQuantity").keyup(function () {
        var UnitPrice = $("#txtUnitPrice").val();
        var Quantity = $("#txtQuantity").val();
        var Discount = $("#txtDiscount").val();

        var Total = (UnitPrice * Quantity) - Discount;

        $("#txtTotal").val(parseFloat(Total).toFixed(2));

        //$('#txtTotalPrice').val($("#txtQuantity").val() * $("#txtSellingPrice").val());
    });
});