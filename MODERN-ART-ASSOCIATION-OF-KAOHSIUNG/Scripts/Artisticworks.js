$(document).ready(function () {
    
    $.ajax({
        url: '/Artisticworks/GetData',
        type: 'GET',

        dataType: 'json',
        success: function (data) {
            //data[0].Artisticworks_Date = "123";
            console.log(data);
        },
        error: function () {
            console.log("無法取得db");
        }
    });

});

    
