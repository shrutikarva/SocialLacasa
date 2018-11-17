var SaveUser = function () {
    alert(1);
    var serviceURL = '/Service/SaveUser';
   
    var obj = {};
    var isChecked = $('#chkCaptcha').is(":checked");
    obj.userName = $("#txtusername").val();
    obj.password = $("#txtpassword").val(); 
    obj.email = $("#txtemail").val(); 
    if (isChecked==false) {
        $.ajax({
            type: "POST",
            url: serviceURL,
            data: JSON.stringify(obj),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: successFunc,
            error: errorFunc
        });

        function successFunc(data, status) {

            alert("User Saved.");
        }

        function errorFunc(err) {
            alert(err.responseText);
        }
    }
    else {
        alert("Please confirm that you are not a robot!")
    }

}