function login() {
    //var username = document.getElementById("username").val;
    //var password = document.getElementById("password").val;
    var username = $("#username").val();
    var password = $("#password").val();
    $.ajax({
        type: 'POST',
        url: `${configuration.BASE_API_URL}Account/login?username=${username}&password=${password}`,
        success: function (result) {
           
            var d = Date.parse(result.user.validTo);
            var a = new Date();
            a.setTime(d);
            if (result.user.avatar !== null) {
                var oldHandle = result.user.avatar.replace("https://cdn.filestackcontent.com/", "");
                document.cookie = "avatar=https://cdn.filestackcontent.com/resize=height:50/" + oldHandle + "; expires=" + a.toUTCString();
            }
            document.cookie = "accessToken=" + result.user.token + "; expires=" + a.toUTCString();
            document.cookie = "username=" + username + "; expires=" + a.toUTCString();
           
            document.cookie = "homeurl=" + result.homeUrl + "; expires=" + a.toUTCString();
            window.location = result.homeUrl;
        },
        statusCode: {
            401: function (result) {
                $('#msgError').text(result.responseJSON.data.msg);
            }
        },
        Error: function (result) {
            $('#msgError').text(result.responseJSON.data.msg);
        }
    });
}

function checkAuthorized() {
    var token = getCookie("accessToken");
    if (token == "") {
        window.location = "/login";
    } else {
        $("#username").text(`${configuration.USERNAME}`);
        var avatar = `${configuration.AVATAR}`;
        if (avatar !== null && avatar !== "") {
            $('#avatar').attr("src", avatar);
        }
      
    }
}

function logout() {
    document.cookie = "accessToken=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
    document.cookie = "username=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
    document.cookie = "homeurl=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
    document.cookie = "avatar=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
    checkAuthorized();
}


function retrivePassword() {
    var username = $("#username").val();
    var email = $("#email").val();
    $.ajax({
        type: 'POST',
        url: `${configuration.BASE_API_URL}Account/retrivePassword?username=${username}&email=${email}`,
        success: function (result) {
            if (result.success) {
                swal({
                    title: result.data.title,
                    text: result.data.msg,
                    type: "success"
                }, function () {
                    window.location = "/";
                });
            }
        }
    });
}

function changePassword() {
    //alert("OK");
    var oldPassword = $('#oldPassword').val();
    var newPassword = $('#newPassword').val();
    var confirmPassword = $('#confirmPassword').val();
    if (newPassword !== confirmPassword) {
        $('#msgError').text("Mật khẩu xác nhận không đúng");
        return;
    }
    if (oldPassword === "" || newPassword === "" || confirmPassword === "") {
        $('#msgError').text("Chưa nhập đủ thông tin");

    }
    var formData = new FormData();
    formData.append("currentPassword", oldPassword);
    formData.append("newPassword", newPassword);
    formData.append("confirmNewPassword", confirmPassword);
    $.ajax({
        url: `${configuration.BASE_API_URL}Account/change-password`,
        headers: {
            "Authorization": `${configuration.ACCESSTOKEN}`,
        },
        method: "PUT",
        data: formData,
        processData: false,
        contentType: false,
        success: function (result) {
            if (result.success) {
                $('#msgError').text(result.data.msg);
                logout();
            } else {
                $('#msgError').text(result.data.msg);
            }
        },
        error: function (result) {
            $('#msgError').text(result.responseJSON.data.msg);
        }
    });

}

var regexpass = new RegExp("^(?=.*[A-Za-z])(?=.*\\d)(?=.*[$@$!%*#?&])[A-Za-z\\d$@$!%*#?&]{8,}$");
function register() {
    var password = $('#password').val();
    var confirmPassword = $('#confirmpassword').val();
    var username = $('#username').val();
    var email = $('#email').val();
    var name = $('#name').val();
    var roleName = "User";
    var regexpass = new RegExp('^(?=.*[A-Za-z])(?=.*\\d)(?=.*[$@$!%*#?&])[A-Za-z\\d$@$!%*#?&]{8,}$');

    if (!regexpass.test(password)) {
        $('#msgError').text("Mật khẩu phải ít nhất 8 kí tự gồm 1 chữ hoa, 1 số, 1 chữ thường và 1 kí tự đặc biệt");
        return;
    }

    if (password !== confirmPassword) {
        $('#msgError').text("Mật khẩu xác nhận không đúng");
        return;
    }
    if (username === "" || password === "" || confirmPassword === "" || email === "") {
        $('#msgError').text("Chưa nhập đủ thông tin");

    }
    var formData = new FormData();
    formData.append("userName", username);
    formData.append("password", password);
    formData.append("confirmPassword", confirmPassword);
    formData.append("email", email);
    formData.append("fullName", name);
    formData.append("roleId", roleName);
    $.ajax({
        url: `${configuration.BASE_API_URL}Account/register`,
        headers: {
            "Authorization": `${configuration.ACCESSTOKEN}`,
        },
        method: "POST",
        data: formData,
        processData: false,
        contentType: false,
        success: function (result) {
            if (result.success) {
                $('#msgError').text(result.msg);
                window.location = "/";
            } else {
                $('#msgError').text(result.msg);
            }
        },
        error: function (result) {
            $('#msgError').text(result.responseJSON.data.msg);
        }
    });

}
// execute directly