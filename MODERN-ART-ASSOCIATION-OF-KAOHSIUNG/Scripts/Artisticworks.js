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
    $.ajax({
        url: '/Artisticworks/CreateArtisticwork',
        type: 'GET',
        data: {Artisticworks_Name:'test1',Artisticworks_Date:'2015/08/22',Artisticworks_Picture:'暫無資料',Member_ID:5},
        dataType: 'json',
        success: function (data) {
            console.log("test");
        },
        error: function () {
            console.log("無法取得db");
        }
    });
});

    
