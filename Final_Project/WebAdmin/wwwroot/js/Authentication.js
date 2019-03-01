function login() {
    //var username = document.getElementById("username").val;
    //var password = document.getElementById("password").val;
    var username = $("#username").val();
    var password = $("#password").val();
    $.ajax({
        type: 'POST',
        url: `${configuration.BASE_API_URL}Account/login?username=${username}&password=${password}`,
        success: function (result) {
            var d = Date.parse(result.validTo);
            var a = new Date();
            a.setTime(d);
            document.cookie = "accessToken=" + result.token + "; expires=" + a.toUTCString();
            document.cookie = "username=" + username + "; expires=" + a.toUTCString();
            //// Check browser support
            //if (typeof (Storage) !== "undefined") {
            //    // Store
            //    localStorage.setItem("accessToken", result.token);
            //} else {
            //    alert("Invalid Login!");
            //}
            //$("#account").submit();
            window.location = "/";
        }
    });
}

function checkAuthorized() {
    var token = getCookie("accessToken");
    if (token == "") {
        window.location = "/login";
    } else {
        return true;
    }
}

function logout() {
    document.cookie = "accessToken=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
    document.cookie = "username=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
    checkAuthorized();
}
// execute directly