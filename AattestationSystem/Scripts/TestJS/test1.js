

$(document).ready(function ()
{
    var interval = setInterval(refreshAsyncContainer, 1000);


});


refreshAsyncContainer = function ()
{
    var asyncContainer = $('.async-container');
    asyncContainer.html('');

    var date = new Date().toLocaleString();
    var p = $('<p>').html('Местное время '+date);
    asyncContainer.append(p);

    var button = $('<button>').addClass('btn btn-primary').html('Вывести текст');
    asyncContainer.append(button);
};