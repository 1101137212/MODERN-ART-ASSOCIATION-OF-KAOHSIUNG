$(document).ready(function () {
    $.ajax({
        url: '/BMember/GetMemberdata',
        type: 'GET',

        dataType: 'json',
        success: function (data) {
            console.log(data);
        },
        error: function () {
            console.log("無法取得db");
        }
    });

});