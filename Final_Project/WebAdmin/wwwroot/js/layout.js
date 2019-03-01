function getMenu() {
    $.ajax({
        type: 'GET',
        url: `${configuration.BASE_API_URL}Menu/getMenu`,
        headers: {
            "Authorization": `${ configuration.ACCESSTOKEN}`
        },
        success: function (result) {
            result.forEach(function (item) {
                var menuItem = '<li>'
                    + '<a class="waves-effect waves-dark" aria-expanded="false" href="' + item.url + '">' + item.icon + '<span class="hide-menu">' + item.title + '</span></a>'
                    + '</li> <li class="nav-devider"></li>';
                $("#sidebarnav").append(menuItem);
                           
            });
          
        }
    });
}