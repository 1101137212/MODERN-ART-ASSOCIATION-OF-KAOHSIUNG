$(document).ready(function () {
    $.ajax({
        url: '/BArtisticworks/GetData',
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
        url: '/BArtisticworks/CreateArtisticwork',
        type: 'POST',
        data: {
            Artisticworks_Name: 'test444',
            Artisticworks_Date: '2015/08/14',
            Artisticworks_Picture: '暫無資料444',
            Member_ID: 4
        },
        dataType: 'json',
        success: function (data) {
            console.log("test");
        },
        error: function () {
            console.log("無法取得db");
        }
    });
    //$.ajax({
    //    url: '/BArtisticworks/UpdateArtisticwork',
    //    type: 'POST',
    //    data: {
    //        Artisticworks_Name: 'test111',
    //        Artisticworks_Date: '2015/08/12',
    //        Artisticworks_Picture: '暫無資料12345',
    //        Member_ID: 14,
    //        Artisticworks_ID: 46
    //    },
    //    dataType: 'json',
    //    success: function (data) {
    //        console.log("test");
    //    },
    //    error: function () {
    //        console.log("無法取得db");
    //    }
    //});
    //$.ajax({
    //    url: '/BArtisticworks/DeleteArtisticwork',
    //    type: 'POST',
    //    data: {
    //        Artisticworks_ID: 45,
    //    },
    //    dataType: 'json',
    //    success: function (data) {
    //        console.log("test");
    //    },
    //    error: function () {
    //        console.log("無法取得db");
    //    }
    //});
});