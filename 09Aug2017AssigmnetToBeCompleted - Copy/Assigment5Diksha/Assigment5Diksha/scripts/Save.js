
    $(document).ready(function () {  
        //function will be called on button click having id btnsave
        $("#btnSave").click(function () {  
            $.ajax(  
            {  
                type: "POST", //HTTP POST Method  
                url: "Home/Create", // Controller/View   
                data: { //Passing data  
                    Name: $("#EmployeeName").val(), //Reading text box values using Jquery   
                    City: $("#Email").val(),
                    City: $("#Phone").val(),
                    City: $("#MaritialStatus").val(),
                    City: $("#State").val(),
                    Address: $("#City").val()  
                }  
  
            });  
  
        });  
    });  
  
