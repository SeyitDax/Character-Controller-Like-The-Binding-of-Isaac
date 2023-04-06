# Character-Scripts-GameJam

Bu ikisi için yapmanız gereken birkaç şey var onları heöen sıralıyacağım

Önelikle Saldırı karaktere düşman ise düşman karakterlere bağlanacak

-Düşmananlar için bir Layer oluşturulup Karakterin üzerindeki saldırı scriptindeki -düşmanLayers- a bağlanacak

-Tabi Düşmanı Düşmanlar için yaptığımız Layera taşınması gerek

-Bir tane Empty yaratılıp istediğimiz saldırı alanının ortasına koyulup karakterin üzerindeki Saldırı Scriptindeki -saldırıNoktası- denilen yerde belirtilecek

-Animasyonlar için Parametre kodlarını hallettim bunun için 3 parametre yapılacak aşağıdaki şekilde
  + Saldır(Trigger) 
  + Vurul(Trigger) 
  + Ölü(Bool) 

-Animasyon arası geçişlerde kolaylık sağlar hepsi

-Geri kalanını Animsayon Parametreleri ile uğraşırken hallederiz. 
