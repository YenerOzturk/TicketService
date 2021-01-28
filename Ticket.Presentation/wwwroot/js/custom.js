

function FillDropDown(url, name,selectedValue=null,data = null, callback = null) {

    $.ajax({
        type: 'GET',
        url: url,
        data: data,
        success: function (data) {

            $('[name="' + name + '"]').empty();
            $.each(data, function (index, value) {
                $('[name="' + name + '"]').append($('<option>').text(value.desc).attr('value', value.val));
            });

            if (selectedValue!=null)
            $('[name="' + name + '"]').val(selectedValue);

        }
    }).done(function () {
        if (callback != null)
            callback();
    });;
}

function FillMultiDropDown(url, id, selectedValue = null, data = null, callback = null) {

    $.ajax({
        type: 'GET',
        url: url,
        data: data,
        success: function (data) {

            $('#' + id).empty();
            $.each(data, function (index, value) {
                $('#' + id).append($('<option>').text(value.desc).attr('value', value.val));
            });

            $('#'+id).multiselect({
                enableFiltering: true,
                includeSelectAllOption: true,
                enableCaseInsensitiveFiltering: true,
                buttonWidth: '100%'
            });



        }
    }).done(function () {
        if (callback != null)
            callback();
    });;
}


function FillDropDownWithPrfx(url, name, data = null, callback = null) {

    var a = $(name);

    $.ajax({
        type: 'GET',
        url: url,
        data: data,
        success: function (data) {

            $(name).empty();
            $.each(data, function (index, value) {
                $(name).append($('<option>').text(value.desc).attr('value', value.val));
            });



        }
    }).done(function () {
        if (callback != null)
            callback();
    });;
}


function RenderDateTimePicker(selector, date) {

    var picker = $('#' + selector).datetimepicker({
        todayHighlight: true,
        autoclose: true,
        format: 'dd.mm.yyyy hh:ii',
    });

    $('#' + selector).on('changeDate', function (e) { $('[name="' + selector + '"]').val(moment(e.date).format()); })

    $('[name="' + selector + '"]').val(date);

    if (date==='') {
        picker.datetimepicker('setDate', new Date());
        $('[name="' + selector + '"]').val(moment(new Date()).format());

    } else {
        picker.datetimepicker('setDate', new Date(date));
        $('[name="' + selector + '"]').val(moment(new Date(date)).format());
    }
}



function RenderDatePicker(selector, date) {

    var picker = $('#' + selector).datepicker({
        todayHighlight: true,
        autoclose: true,
        format: 'dd.mm.yyyy',
    });

    $('#' + selector).on('changeDate', function (e) { $('[name="' + selector + '"]').val(moment(e.date).format()); })

    $('[name="' + selector + '"]').val(new Date(date).toISOString());

    if (date === '') {
        picker.datepicker('setDate', new Date());
    } else {
        picker.datepicker('setDate', new Date(date));
    }
}


function ShowMessageBox(title,text,icon,callback) {

    Swal.fire({
        title: title,
        text: text,
        icon: icon,
        showCancelButton: true,
        confirmButtonText: "Evet",
        cancelButtonText: "Hayır"
    }).then(function (result) {
        if (result.value) {

            if (callback !== undefined && callback !== null) {
                callback();
            }

        }
    });

}

function GetFormatedDate(date) {

   var formatted = date.getFullYear() + "-" + (date.getMonth() + 1) + "-" + date.getDate() + " " + date.getHours()+ ":" + date.getMinutes() + ":" + date.getSeconds();

    return formatted;
}