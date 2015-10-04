$(document).ready(function () {
    $.ajax({
        url: '/BLN/GetAwardRecorddata_B',
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
    //    url: '/BLN/CreateAwardRecorddata_B',
    //    type: 'POST',
    //    data: {
    //        AwardRecord_Date: '2015/08/30',
    //        Award_ID: 1,
    //        Member_ID: 5
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
    //    url: '/BLN/UpdateAwardRecorddata_B',
    //    type: 'POST',
    //    data: {
    //        AwardRecord_Date: '2015/09/03',
    //        Award_ID: 2,
    //        Member_ID: 4,
    //        AwardRecord_ID: 7
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
    //    url: '/BLN/DeleteAwardRecorddata_B',
    //    type: 'POST',
    //    data: {
    //        AwardRecord_ID: 7
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