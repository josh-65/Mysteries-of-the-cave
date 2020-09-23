function timedate() {
    var today = new Date();
    var date = today.getDay()+'/'+(today.getMonth()+1)+'/'+today.getFullYear();
    var hours = today.getHours() % 12 || 12;
    var time = hours + ":" + today.getMinutes() + ":" + today.getSeconds();


    var output = time+' - '+date;
    document.getElementById("timedate").innerHTML = output;
};

setInterval(timedate, 100);
