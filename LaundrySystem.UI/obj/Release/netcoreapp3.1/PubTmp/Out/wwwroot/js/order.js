
$(document).ready(function () {
    $("#cboProduct").change(function () {
        var ProductID = $("#cboProduct").val();
        var url = "/data/GetUnitPriceByProductId?ProductID=" + ProductID;
        let options = "<option value='-1' selected>Select Product </option>";
        $.get(url, function (data, status) {
            $("#txtUnitPrice").val(data[0].productPrice);
        });
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

$(document).ready(function () {
    $("#btnAddToList").click(function () {
        var tblItemList = $("#tblOrderItemList");
        var UnitPrice = $("#txtUnitPrice").val();
        var Quantity = $("#txtQuantity").val();
        var Discount = $("#txtDiscount").val();
        var ProductId = $("#cboProduct").val();
        var ProductName = $("#cboProduct option:selected").text();
        var Total = (UnitPrice * Quantity) - Discount;

        var itemList = "<tr><td hidden>" + 
            ProductId + 
            "</td><td>" + 
            ProductName + 
            "</td><td>" + 
            parseFloat(UnitPrice).toFixed(2) + 
            "</td><td>" + 
            Quantity + 
            "</td><td>" + 
            parseFloat(Total).toFixed(2) + 
            "</td><td> <input type='button' value='Remove' class='btn btn-danger' onclick='RemoveItem(this)'/> </td></tr>";

        tblItemList.append(itemList);

        FinalTotalItem();

        $("#txtUnitPrice").val(0.00);
        $("#txtQuantity").val(0);
        $("#txtDiscount").val(0);
        $("#cboProduct").val(0);
        $("#txtTotal").val(0.00);
    });
});

function RemoveItem(itemId) {
    $(itemId).closest('tr').remove();
}

function FinalTotalItem() {
    $("#txtFinalTotal").val(0.00);
    var FinalTotal = 0.00;
    $("#tblOrderItemList").find("tr:gt(0)").each(function() {
        var Total = parseFloat($(this).find("td:eq(4)").text());
        FinalTotal += Total;
    });

    $("#txtFinalTotal").val(parseFloat(FinalTotal).toFixed(2));

    $("#txtPaymentTotal").val(parseFloat(FinalTotal).toFixed(2));
}

$(document).ready(function () {
    $("#txtBalance").keyup(function () {
        var Balance = $("#txtBalance").val();
        var PaymentAmount = $("#txtPaymentAmount").val();
        var PaymentTotal = $("#txtPaymentTotal").val();
        var ReturnTotal = $("#txtReturnTotal").val();
        $("#txtBalance").val(PaymentTotal);

        Balance = (PaymentAmount - PaymentTotal) + ReturnTotal;

        $("#txtBalance").val(parseFloat(Balance).toFixed(2));
    });
});

$(document).ready(function () {
    $("#btnPayment").click(function () {
        var objModel = {};
        var ListOfOrderDetails = new Array();

        objModel.CustomerID = $("#cboCustomer").val();
        objModel.Discount = $("#txtDiscount").val();
        objModel.NetTotal = $("#txtPaymentTotal").val();
        objModel.SaleTotal = $("#txtPaymentTotal").val();
        objModel.Balance = $("#txtBalance").val();
        objModel.CustomerName = $("#cboCustomer").text();
        objModel.ServiceId = $("#cboService").val();
        objModel.ServiceName = $("#cboService").text();

        $("#tblOrderItemList").find("tr:gt(0)").each(function () {
            var OrderDetailModel = {};

            OrderDetailModel.ProductId = $(this).find("td:eq(0)").text();
            OrderDetailModel.ProductName = $(this).find("td:eq(1)").text();
            OrderDetailModel.SellingPrice = parseFloat($(this).find("td:eq(2)").text());
            OrderDetailModel.QtySold = parseFloat($(this).find("td:eq(3)").text());
            OrderDetailModel.SaleDetailTotal = parseFloat($(this).find("td:eq(4)").text());

            ListOfOrderDetails.push(OrderDetailModel);
        });

        objModel.ListOfOrderDetails = ListOfOrderDetails;

        $.post("/Order/PostOrderTransaction", objModel, function (data) {

            $('#txtUnitPrice').val(0);
            $('#txtQuantity').val(0);
            $('#txtDiscount').val(0);
            $('#txtPaymentAmount').val(0);
            $('#txtBalance').val(0);
            $('#txtPaymentTotal').val(0);
            $('#txtReturnTotal').val(0);
        });

        //$("#divPayment").hide();
        $('#divPayment').modal('hide');
    })
});