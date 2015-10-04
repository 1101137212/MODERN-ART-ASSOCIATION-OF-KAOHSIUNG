$(document).ready(function () {
    $.ajax({
        url: '/BLN/GetAwarddata_B',
        type: 'POST',
        dataType: 'json',
        success: function (data) {
            console.log(data);
        },
        error: function () {
            console.log("無法取得db");
        }
    });
    //$.ajax({
    //    url: '/BLN/CreateAwarddata_B',
    //    type: 'POST',
    //    data: {
    //        Award_Title: 'test333',
    //        Award_Detail: '2015/08/30',
    //        Award_Picture: 'test333'
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
    //    url: '/BLN/UpdateAwarddata_B',
    //    type: 'POST',
    //    data: {
    //        Award_Title: 'test33345',
    //        Award_Detail: 'test',
    //        Award_Picture: 'test33345',
    //        Award_ID: 4
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
    //    url: '/BLN/DeleteAwarddata_B',
    //    type: 'POST',
    //    data: {
    //        Award_ID: 5
    //    },
    //    dataType: 'json',
    //    success: function (data) {
    //        console.log("test");
    //    },
    //    error: function () {
    //        console.log("無法取得db");
    //    }
    //});
})