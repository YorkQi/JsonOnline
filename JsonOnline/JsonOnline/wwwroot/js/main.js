$('textarea').numberedtextarea();
var current_json = '';
var current_json_str = '';
var xml_flag = false;
var zip_flag = false;
var shown_flag = false;
var compress_flag = false;
var xml_text;
$('.tip').tooltip();
function init() {
    xml_flag = false;
    zip_flag = false;
    shown_flag = false;
    compress_flag = false;
    renderLine();
    $('.xml').attr('style', 'color:#999;');
    $('.zip').attr('style', 'color:#999;');
}
$('#json-src').keyup(function () {
    init();
    var content = $.trim($(this).val());
    var result = '';
    if (content != '') {
        //如果是xml,那么转换为json
        if (content.substr(0, 1) === '<' && content.substr(-1, 1) === '>') {
            try {
                var json_obj = $.xml2json(content);
                content = JSON.stringify(json_obj);
            } catch (e) {
                result = '解析错误：<span style="color: #f1592a;font-weight:bold;">' + e.message + '</span>';
                current_json_str = result;
                $('#json-target').html(result);
                return false;
            }
        }
        try {
            content = content.replace(/[\r\n]/g, "");
            current_json = jsonlint.parse(content);
            current_json_str = JSON.stringify(current_json);
            result = new JSONFormat(content, 4).toString();
        } catch (e) {
            result = '<span style="color: #f1592a;font-weight:bold;">' + e + '</span>';
            current_json_str = result;
        }
        $('#json-target').html(result);
    } else {
        $('#json-target').html('');
    }
});
$('.xml').click(function () {
    if (xml_flag) {
        $('#json-src').keyup();
    } else {
        var result = $.json2xml(current_json);
        $('#json-target').html('<textarea style="width:100%;position:absolute;height: 80vh;min-height:480px;border:0;resize:none;">' + result + '</textarea>');
        xml_text = result;
        xml_flag = true;
        $(this).attr('style', 'color:#15b374;');
    }
});
$('.shown').click(function () {
    if (!shown_flag) {
        renderLine();
        $('#json-src').attr("style", "height:722px;padding:0 10px 10px 40px;border:0;border-right:solid 1px #ddd;border-bottom:solid 1px #ddd;border-radius:0;resize: none; outline:none;");
        $('#json-target').attr("style", "padding:0px 50px;");
        $('#line-num').show();
        $('.numberedtextarea-line-numbers').show();
        shown_flag = true;
        $(this).attr('style', 'color:#15b374;');
    } else {
        $('#json-src').attr("style", "height:722px;padding:0 10px 10px 20px;border:0;border-right:solid 1px #ddd;border-bottom:solid 1px #ddd;border-radius:0;resize: none; outline:none;");
        $('#json-target').attr("style", "padding:0px 20px;");
        $('#line-num').hide();
        $('.numberedtextarea-line-numbers').hide();
        shown_flag = false;
        $(this).attr('style', 'color:#999;');
    }
});
function renderLine() {
    var line_num = $('#json-target').height() / 20;
    $('#line-num').html("");
    var line_num_html = "";
    for (var i = 1; i < line_num + 1; i++) {
        line_num_html += "<div>" + i + "<div>";
    }
    $('#line-num').html(line_num_html);
}
$('.zip').click(function () {
    if (zip_flag) {
        $('#json-src').keyup();
    } else {
        $('#json-target').html(current_json_str);
        zip_flag = true;
        xml_flag = false;
        $(this).attr('style', 'color:#15b374;');
    }

});
$('.compress').click(function () {
    if (!compress_flag) {
        $(this).attr('style', 'color:#15b374;');
        //$(this).attr('title','取消折叠').tooltip('fixTitle').tooltip('show');
        $($(".fa-minus-square-o").toArray().reverse()).click();
        compress_flag = true;
    } else {
        while ($(".fa-plus-square-o").length > 0) {
            $(".fa-plus-square-o").click();
        }
        compress_flag = false;
        $(this).attr('style', 'color:#555;');
        $(this).attr('title', '折叠').tooltip('fixTitle').tooltip('show');
    }
});
$('.clear').click(function () {
    $('#json-src').val('');
    $('#json-target').html('');
});
(function ($) {
    $.fn.innerText = function (msg) {
        if (msg) {
            if (document.body.innerText) {
                for (var i in this) {
                    this[i].innerText = msg;
                }
            } else {
                for (var i in this) {
                    this[i].innerHTML.replace(/&amp;lt;br&amp;gt;/gi, "n").replace(/(&amp;lt;([^&amp;gt;]+)&amp;gt;)/gi, "");
                }
            }
            return this;
        } else {
            if (document.body.innerText) {
                return this[0].innerText;
            } else {
                return this[0].innerHTML.replace(/&amp;lt;br&amp;gt;/gi, "n").replace(/(&amp;lt;([^&amp;gt;]+)&amp;gt;)/gi, "");
            }
        }
    };
})(jQuery);
$('.save').click(function () {
    //console.log('xml_flag' +'<br/>'+ xml_flag);
    var text;
    if (xml_flag) {
        var text1 = $.trim($('#json-src').val());
        // console.log('text1' +'<br/>'+ text1);
        text = xml_text;
        //console.log('text' +'<br/>'+ text);
    } else {
        var html = $('#json-target').html().replace(/\n/g, '<br/>').replace(/\n/g, '<br>');
        text = $('#json-target').innerText().replace('　　', '    ');
        // console.log('text' +'<br/>'+ text);
    }
    var blob = new Blob([text], { type: "application/json;charset=utf-8" });
    var timestamp = new Date().getTime();
    saveAs(blob, "format." + timestamp + ".json");
});
$('.copy').click(function () {
});
var clipboard = new Clipboard('.copy');
$('#json-src').keyup();