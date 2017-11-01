
   $(document).ready(function () {
       debugger;
       $("#Jdatatable").DataTable({
           "ajax": {
               "url": "Home/GetData",
               "type": "GET",
               "datatype":"json"
           },
           "columns": [

                       { "data": "FirstName", "autoWidth": true },
                       { "data": "LastName", "autoWidth": true },
                       { "data": "Class", "autoWidth": true },
                       { "data": "RollNo", "autoWidth": true },
                       { "data": "studentdetails", "autoWidth": true },
           {
               data: null,
               className: "center",
               defaultContent: '<a href="../Home/Edit" class="editor_edit">Edit</a> | <a href="../Home/Detele" class="editor_remove">Delete</a>'
           },
           ]
       });
   });















/*$(function () {

    $("#jqGrid").jqGrid({
        url: "api/Students/GetStudents",
        datatype: 'json',
        mtype: 'Get',
        colNames: ['Id', 'FirstName', 'LastName', 'Class', 'RollNo', 'studentsdetails'],
        colModel: [
            { key: true, hidden: true, name: 'Id', index: 'Id', editable: true },
            { key: false, name: 'FirstName', index: 'FirstName', editable: true },
            { key: false, name: 'LastName', index: 'LastName', editable: true },
            { key: false, name: 'Class', index: 'Class', editable: true },
            { key: false, name: 'RollNo', index: 'RollNo', editable: true },
            { key: false, name: 'studentsdetails', index: 'studentsdetails', editable: true }
           ],
        pager: jQuery('#jqControls'),
        rowNum: 10,
        rowList: [10, 20, 30, 40, 50],
        height: '100%',
        viewrecords: true,
        caption: 'Customers Records',
        emptyrecords: 'No Students Records are Available to Display',
        jsonReader: {
            root: "rows",
            page: "page",
            total: "total",
            records: "records",
            repeatitems: false,
            Id: "0"
        },
        autowidth: true,
        multiselect: false
    }).navGrid('#jqControls', { edit: true, add: true, del: true, search: false, refresh: true },
        {
            zIndex: 100,
            url: '/JQGrid/Edit',
            closeOnEscape: true,
            closeAfterEdit: true,
            recreateForm: true,
            afterComplete: function (response) {
                if (response.responseText) {
                    alert(response.responseText);
                }
            }
        },
        {
            zIndex: 100,
            url: "/JQGrid/Create",
            closeOnEscape: true,
            closeAfterAdd: true,
            afterComplete: function (response) {
                if (response.responseText) {
                    alert(response.responseText);
                }
            }
        },
        {
            zIndex: 100,
            url: "/JQGrid/Delete",
            closeOnEscape: true,
            closeAfterDelete: true,
            recreateForm: true,
            msg: "Are you sure you want to delete Student... ? ",
            afterComplete: function (response) {
                if (response.responseText) {
                    alert(response.responseText);
                }
            }
        });
});

*/

















//var API_URL = "api/Students/";
//jQuery("#jqGrid").jqGrid({
//    url: API_URL,
//    datatype: 'json',
//    mtype: 'GET',
//    pager: '#jqControls',
//    sortable: true,
//    height: 200,
//    viewrecords: true,
//    colNames: ['Id', 'FirstName', 'LastName', 'Class', 'RollNo', 'FatherName', 'MotherName', 'Address', 'MobileNo'],
//    colModel: [{ name: 'Id', index: 'Id', width: 40, sorttype: "int" },
//     { name: 'FirstName', index: 'FirstName', editable: true, edittype: 'text', width: 70 },
//     { name: 'LastName', index: 'LastName', editable: true, edittype: 'text', width: 70 },
//     { name: 'Class', index: 'Course', editable: true, edittype: 'text', width: 70 },
//     { name: 'RollNo', index: 'RollNo', editable: true, edittype: 'text', width: 70 },
//     { name: 'studentdetails', index: 'studentdetails', editable: true, edittype: 'text', width: 70 }
//     //{ name: 'FatherName', index: 'Address', editable: true, edittype: 'text', width: 70 },
//     //{ name: 'MotherName', index: 'Email', editable: true, edittype: 'text', width: 70 },
//     //{ name: 'Address', index: 'City', editable: true, edittype: 'text', width: 70 },
//     //{ name: 'MobileNo', index: 'City', editable: true, edittype: 'text', width: 70 }

//    ],
//    caption: "CRUD With ASP.NET Web API",
//    autowidth: true

//});