function timedate() {
    var today = new Date();
    var date = today.getDay()+'/'+(today.getMonth()+1)+'/'+today.getFullYear();
    var time = today.getSeconds() + ":" + today.getMinutes() + ":" + today.getHours();

    var output = time+' - '+date;
    document.getElementById("timedate").innerHTML = output;
};

setInterval(timedate, 100);