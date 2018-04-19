(function () {

    var setCookieDialog = function() {
        if(getCookie('isCookiePolicySet') == '') {
            $('.js-widget-cookie-policy').removeClass('js-hide');
        } else {
            $('.widget-cookie-policy').remove();
        }
    }

    var getCookie = function(cookieKey) {
        var name = cookieKey + '=';
        var decodedCookie = decodeURIComponent(document.cookie);
        var ca = decodedCookie.split(';');
        for(var i = 0; i <ca.length; i++) {
            var c = ca[i];
            while (c.charAt(0) == ' ') {
                c = c.substring(1);
            }
            if (c.indexOf(name) == 0) {
                return c.substring(name.length, c.length);
            }
        }
        return "";
    }

    var setCookie = function(cookieKey, cookieValue) {
        var d = new Date();
        d.setTime(d.getTime() + (365*24*60*60*1000));
        var expires = 'expires='+ d.toUTCString();
        document.cookie = cookieKey + '=' + cookieValue + ';' + expires + ';path=/';
    }

    $('.js-cookie-policy-close').on('click', function() {
        setCookie('isCookiePolicySet', 'true');
        $('.widget-cookie-policy').remove();
    });

    setCookieDialog();

})();