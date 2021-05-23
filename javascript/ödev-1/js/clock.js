 let userName = document.querySelector("#myName");
 let myName = prompt('Adınız Nedir?');

 if (myName == null && myName == "") {
     alert('Lutfen bos bırakmayınız!')
     location.reload();
 } else {
     userName.textContent = `${myName} `;
     userName.style.color = 'green';

 }

 function showTime() {
     let date = new Date();
     let yil = date.getFullYear();
     let gun = date.getDay();
     let sa = date.getHours();
     let dk = date.getMinutes();
     let sn = date.getSeconds();


     switch (gun) {
         case 1:
             gun = "Pazartesi";
             break;
         case 2:
             gun = "Salı";
             break;
         case 3:
             gun = "Çarşamba";
             break;
         case 4:
             gun = "Perşembe";
             break;
         case 5:
             gun = "Cuma";
             break;
         case 6:
             gun = "Cumartesi";
             break;
         case 7:
             gun = "Pazar";
             break;

     }
     //Eğer saat, dakika ya da saniye 10'dan küçükse başına 0'ı koy
     sa = sa < 10 ? "0" + sa : sa;
     dk = dk < 10 ? "0" + dk : dk;
     sn = sn < 10 ? "0" + sn : sn;
     let clock = sa + ":" + dk + ":" + sn + " " + gun + " " + yil;
     document.querySelector("#myClock").textContent = clock;
     //Her 1 saniyede bir yenile
     setTimeout(showTime, 1000);
 }
 showTime();