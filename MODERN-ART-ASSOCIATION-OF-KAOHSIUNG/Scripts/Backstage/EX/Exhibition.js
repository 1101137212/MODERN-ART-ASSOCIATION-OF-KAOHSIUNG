$(document).ready(function () {
    $.ajax({
        url: '/BEX/GetExhibitiondata_B',
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
    //    url: '/BEX/CreateExhibitiondata_B',
    //    type: 'POST',
    //    data: {
    //        Exhibition_Title: 'test333',
    //        Exhibition_Startdatetime: '2015/08/30',
    //        Exhibition_Enddatetime: '2015/09/04',
    //        Exhibition_Place: '暫無資料',
    //        Exhibition_Detail: 'test',
    //        Exhibition_Picture: 'test11',
    //        Exhibition_Otherpeople:'george'
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
    //    url: '/BEX/UpdateExhibitiondata_B',
    //    type: 'POST',
    //    data: {
    //        Exhibition_Title: 'test444',
    //        Exhibition_Startdatetime: '2015/08/31',
    //        Exhibition_Enddatetime: '2015/09/03',
    //        Exhibition_Place: '暫無資料11',
    //        Exhibition_Detail: 'test222',
    //        Exhibition_Picture: 'test11345',
    //        Exhibition_Otherpeople:'georgexkeven',
    //        Exhibition_ID: 49
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
    //    url: '/BEX/DeleteExhibitiondata_B',
    //    type: 'POST',
    //    data: {
    //        Exhibition_ID: 49
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