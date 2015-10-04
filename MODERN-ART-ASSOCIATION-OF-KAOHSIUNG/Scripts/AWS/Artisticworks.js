$(document).ready(function () {
    $.ajax({
        url: '/AWS/GetArtisticworksdata',
        type: 'POST',
        data: {
            Member_ID: 4
            },
        dataType: 'json',
        success: function (data) {
            console.log(data);
        },
        error: function () {
            console.log("無法取得db");
        }
    });
})