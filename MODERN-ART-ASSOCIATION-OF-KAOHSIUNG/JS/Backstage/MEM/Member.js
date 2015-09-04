$(document).ready(function () {
    $.ajax({
        url: '/BMEM/GetMemberdata_B',
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
    //    url: '/BMEM/CreateMemberdata_B',
    //    type: 'POST',
    //    data: {
    //        Member_Name: 'test',
    //        Member_Mobile: '0900000000',
    //        Member_Addresszip: 'test',
    //        Member_Address: 'test',
    //        Member_Picture: 'test',
    //        Member_Email: 'test',
    //        Member_NowPosition: 'test',
    //        Member_Account: 'test',
    //        Member_Password: 'test',
    //        Member_Education: 'test',
    //        Member_Experience: 'test',
    //        Member_Adminname: 'test',
    //        Member_Adminpasswd: 'test'
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
    //    url: '/BMEM/UpdateMemberdata_B',
    //    type: 'POST',
    //    data: {
    //        Member_Name: 'test11',
    //        Member_Mobile: '0900000011',
    //        Member_Addresszip: 'test1',
    //        Member_Address: 'test1',
    //        Member_Picture: 'test1',
    //        Member_Email: 'test1',
    //        Member_NowPosition: 'test1',
    //        Member_Account: 'test1',
    //        Member_Password: 'test1',
    //        Member_Education: 'test1',
    //        Member_Experience: 'test1',
    //        Member_Adminname: 'test1',
    //        Member_Adminpasswd: 'test1',
    //        Member_ID: 19
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
    //    url: '/BMEM/DeleteMemberdata_B',
    //    type: 'POST',
    //    data: {
    //        Member_ID: 19
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