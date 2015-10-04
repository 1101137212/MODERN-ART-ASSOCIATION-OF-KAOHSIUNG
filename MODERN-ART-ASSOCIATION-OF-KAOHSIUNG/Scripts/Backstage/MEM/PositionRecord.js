$(document).ready(function () {
    $.ajax({
        url: '/BMEM/GetPositionRecorddata_B',
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
    //    url: '/BMEM/CreatePositionRecorddata_B',
    //    type: 'POST',
    //    data: {
    //        PositionRecord_Startdate: '2015/09/05',
    //        PositionRecord_Enddate: '2015/09/05',
    //        Member_ID: 1,
    //        Position_ID: 1,
    //        MeetingRecord_ID: 1
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
    //    url: '/BMEM/UpdatePositionRecorddata_B',
    //    type: 'POST',
    //    data: {
    //        Position_Name: 'test11',
    //        Position_Competence: '2',
    //        Position_ID: 15
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
    //    url: '/BMEM/DeletePositionRecorddata_B',
    //    type: 'POST',
    //    data: {
    //        Position_ID: 16
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