﻿$(document).ready(function () {
    $.ajax({
        url: '/BAWS/GetArtisticworksdata_B',
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
    //    url: '/BAWS/CreateArtisticworksdata_B',
    //    type: 'POST',
    //    data: {
    //        Artisticworks_Name: 'test0826',
    //        Artisticworks_Date: '2015/08/26',
    //        Artisticworks_Picture: '暫無資料0826',
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
    //    url: '/BAWS/UpdateArtisticworksdata_B',
    //    type: 'POST',
    //    data: {
    //        Artisticworks_Name: 'test08262',
    //        Artisticworks_Date: '2015/08/27',
    //        Artisticworks_Picture: '暫無資料08262',
    //        Member_ID: 6,
    //        Artisticworks_ID: 56
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
    //    url: '/BAWS/DeleteArtisticworksdata_B',
    //    type: 'POST',
    //    data: {
    //        Artisticworks_ID: 56,
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