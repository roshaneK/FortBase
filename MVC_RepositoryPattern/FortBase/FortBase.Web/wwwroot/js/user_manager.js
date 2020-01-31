$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/api/User/GetUsers",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data !== null && data.result !== null) {
                $('#lblNoOfUsers').text(data.result.length);
            }
            console.log(data);
        }, //End of AJAX Success function  

        failure: function (data) {
            alert(data.responseText);
        }, //End of AJAX failure function  
        error: function (data) {
            alert(data.responseText);
        } //End of AJAX error function  
    });   
});

function saveUser() {
    var fName = $('#fname').val();
    var lName = $('#lname').val();

    if (fName === null || fName === "") {
        alert('Enter First Name !');
    } else if (lName === null || lName === "") {
        alert('Enter Last Name !');
    } else {
        var user = { "FirstName": fName, "LastName": lName };
        $.ajax({
            type: "POST",
            url: "api/User/SaveUser",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify(user),
            success: function(data) {
                if (data !== null && data.result !== null) {
                    $('#lblNoOfUsers').text(data.result.length);
                }
                console.log(data);
            }, //End of AJAX Success function  
            failure: function (data) {
                alert(data.responseText);
            }, //End of AJAX failure function  
            error: function (data) {
                alert(data.responseText);
            } //End of AJAX error function  
        });  
    }
}