$(document).ready(function () {
    $.ajax({
        url: '/AA/GetAssociationEventListData',
        type: 'POST',
        dataType: 'json',
        success: function (data) {
            console.log(data);
        },
        error: function () {
            console.log("無法取得db");
        }
    });
})