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
    //$.ajax({
    //    url: '/Artisticworks/CreateArtisticwork',
    //    type: 'POST',
    //    data: {
    //        Artisticworks_Name: 'test22',
    //        Artisticworks_Date: '2015/08/23',
    //        Artisticworks_Picture: '暫無資料222',
    //        Member_ID: 7
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
    //    url: '/Artisticworks/UpdateArtisticwork',
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
    //    url: '/Artisticworks/DeleteArtisticwork',
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