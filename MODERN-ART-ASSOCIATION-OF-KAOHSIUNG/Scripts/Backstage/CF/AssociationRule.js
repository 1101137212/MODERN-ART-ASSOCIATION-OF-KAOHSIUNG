$(document).ready(function () {
    $.ajax({
        url: '/BCF/GetAssociationRuledata_B',
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
    //    url: '/BCF/CreateAssociationRuledata_B',
    //    type: 'POST',
    //    data: {
    //        AssociationRule_Title: 'test333',
    //        AssociationRule_Detail: '2015/08/30',
    //        AssociationRule_Modifier: 17,
    //        AssociationRule_Modificationdatetime: '2015/08/31'
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
    //    url: '/BCF/UpdateAssociationRuledata_B',
    //    type: 'POST',
    //    data: {
    //        AssociationRule_Title: 'test33345',
    //        AssociationRule_Detail: 'test',
    //        AssociationRule_Modifier: 16,
    //        AssociationRule_Modificationdatetime: '2015/08/31',
    //        AssociationRule_ID: 10
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
    //    url: '/BCF/DeleteAssociationRuledata_B',
    //    type: 'POST',
    //    data: {
    //        AssociationRule_ID: 11
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