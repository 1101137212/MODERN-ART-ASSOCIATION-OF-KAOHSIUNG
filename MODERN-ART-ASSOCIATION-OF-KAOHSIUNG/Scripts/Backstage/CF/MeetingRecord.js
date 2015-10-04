$(document).ready(function () {
    $.ajax({
        url: '/BCF/GetMeetingRecorddata_B',
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
    //    url: '/BCF/CreateMeetingRecorddata_B',
    //    type: 'POST',
    //    data: {
    //        MeetingRecord_Title: 'test333',
    //        MeetingRecord_Detail: 'test',
    //        MeetingRecord_Date: '2015/08/30',
    //        MeetingRecord_Starttime: '10:00:00',
    //        MeetingRecord_Endtime: '11:00:00',
    //        MeetingRecord_Place: 'test',
    //        MeetingRecord_File: 'test',
    //        MeetingRecord_Modificationdatetime: '11:00:00'
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
    //    url: '/BCF/UpdateMeetingRecorddata_B',
    //    type: 'POST',
    //    data: {
    //        MeetingRecord_Title: 'test333456',
    //        MeetingRecord_Detail: 'test111',
    //        MeetingRecord_Date: '2015/08/31',
    //        MeetingRecord_Starttime: '11:00:00',
    //        MeetingRecord_Endtime: '12:00:00',
    //        MeetingRecord_Place: 'test111',
    //        MeetingRecord_File: 'test111',
    //        MeetingRecord_Modificationdatetime: '13:00:00',
    //        MeetingRecord_ID: 6
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
    //    url: '/BCF/DeleteMeetingRecorddata_B',
    //    type: 'POST',
    //    data: {
    //        MeetingRecord_ID: 6
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