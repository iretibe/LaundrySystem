var hostname = "http://localhost:64814";

$(document).ready(function () {
    var table, locationFormData = {}, rowData = {};

    //$("#floatingCountryName").keyup(function () {
    //    var nameInput = $('#floatingCountryName').value;
    //    if (nameInput !== "") {
    //        $('#btnSave').prop("disabled", false);
    //    } else {
    //        $('#btnSave').prop("disabled", true);
    //    }
    //});

    //Initialize the grid
    $('#grdService').DataTable({
        "processing": true,
        "ajax": {
            "url": hostname + "/Service/Inex",
            "dataSrc": ""
        },
        "columns": [
            {
                "data": "ServiceId",
                "autoWidth": true
            },
            {
                "data": "ServiceName",
                "autoWidth": true
            },
            {
                "data": "ServiceImage",
                "autoWidth": true
            },
            {
                "data": "AddedDate",
                "autoWidth": true
            },
            {
                "data": "CreatedBy",
                "autoWidth": true
            },
            {
                "data": "serviceId",
                "width": "100px",
                "render": function (data) {
                    return '<a href="javascript:void(0)" id="btnEdit" class="btn btn-link btn-icon bigger-100 text-success"><i data-feather="edit"></i></a>' +
                        '<a href="javascript:void(0)" id="btnDelete" class="btn btn-link btn-icon bigger-100 text-danger"><i data-feather="trash"></i></a>';
                }
            }
        ]
    })

    ////Add new company location
    //$(document).ready(function myfunction() {
    //    $('#btnSave').click(function () {
    //        var prod = {
    //            countryID: 0,
    //            countryName: $.trim($('#floatingCountryName').val()),
    //            nationality: $.trim($('#floatingNationality').val()),
    //            countryCode: $.trim($('#floatingCountryCode').val())
    //        };

    //        $.post("/Country/PostSingleCountry", prod, function (data) {

    //            $('#basicModal').modal('hide');

    //            $('#myForm').val('');

    //            $('#grdCountry').DataTable().ajax.reload();

    //            new Noty({
    //                type: 'success',
    //                text: '<h5>Sales System!</h5>Country has been successfully saved',
    //                timeout: 2000
    //            }).show()

    //            $('#floatingCountryName').val('');
    //            $('#floatingNationality').val('');
    //            $('#floatingCountryCode').val('');

    //            $('#floatingCountryName').prop("disabled", false);
    //            $('#floatingNationality').prop("disabled", false);
    //            $('#floatingCountryCode').prop("disabled", false);
    //            $('#btnSave').prop("disabled", true);
    //        });
    //    });
    //});

    ////Edit company location
    //$('#grdCountry tbody').on('click', 'td #btnEdit', function () {
    //    var grid = $("#grdCountry").DataTable();
    //    rowData = grid.row($(this).closest('tr')).data();
    //    inRow = grid.row($(this).closest('tr'));

    //    var _id = grid.row($(this).closest('tr')).data().countryID;
    //    //alert(_id);

    //    $('#floatingCountryNames').val(rowData.countryName);
    //    $('#floatingNationalitys').val(rowData.nationality);
    //    $('#floatingCountryCodes').val(rowData.countryCode);

    //    $('#EditbasicModal').modal('show');

    //    $('#btnUpdate').click(function () {
    //        var prod = {
    //            countryID: _id,
    //            countryName: $.trim($('#floatingCountryNames').val()),
    //            nationality: $.trim($('#floatingNationalitys').val()),
    //            countryCode: $.trim($('#floatingCountryCodes').val())
    //        };

    //        $.post("/Country/PutSingleCountry", prod, function (data) {

    //            new Noty({
    //                type: 'success',
    //                text: '<h5>Sales System!</h5>Country has been successfully updated',
    //                timeout: 2000
    //            }).show()

    //            $('#grdCountry').DataTable().ajax.reload();

    //            $('#EditbasicModal').modal('hide');
    //        });
    //    })
    //})

    ////Delete company location
    //$('#grdCountry tbody').on('click', 'td #btnDelete', function () {
    //    var grid = $("#grdCountry").DataTable();
    //    rowData = grid.row($(this).closest('tr')).data();
    //    inRow = grid.row($(this).closest('tr'));

    //    var _id = grid.row($(this).closest('tr')).data().countryID;
    //    //alert(_id);

    //    new Noty({
    //        text: '<h5>Are you sure want to remove this data ?</h5>',
    //        buttons: [
    //            Noty.button('YES', 'btn btn-sm btn-danger rounded-0', function (n) {
    //                n.close() // close noty

    //                // YOUR ACTION HERE
    //                $.post("/Country/DeleteCountry/" + _id, _id, function (data) {
    //                    $('#grdCountry').DataTable().ajax.reload();
    //                });

    //                // If done, show success notification
    //                new Noty({
    //                    type: 'success',
    //                    text: '<h5>Sales System!</h5>ategory has been successfully deleted!',
    //                    timeout: 2000
    //                }).show()
    //            }),
    //            Noty.button('CANCEL', 'btn btn-sm btn-light rounded-0', function (n) {
    //                n.close() // close noty
    //            })
    //        ]
    //    }).show()
    //})

    ////$('#btnPrint').click(function (win) {
    ////    $(win.document.body)
    ////        .css('font-size', '10pt')
    ////        .prepend(
    ////            '<img src="http://datatables.net/media/images/logo-fade.png" style="position:absolute; top:0; left:0;" />'
    ////        );

    ////    $(win.document.body).find('table')
    ////        .addClass('compact')
    ////        .css('font-size', 'inherit');
    ////})
})



//https://stackoverflow.com/questions/53995951/change-data-in-datatable-with-select-from-dropdownlist
//https://www.aspsnippets.com/Articles/Get-selected-row-in-GridView-on-Button-Click-in-ASPNet.aspx