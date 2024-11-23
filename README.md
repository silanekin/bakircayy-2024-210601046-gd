# bakircayy-2024-210601046-gd
youtube link : https://youtu.be/QZxf3p7vZfc
Unity uygulamamı geliştirirken 2022 sürümünü kullanarak yeni bir 3D proje oluşturdum. Sahneye temel bileşenler olarak zemin, ana kamera ve ışıklandırma ekledim. Daha sonra yerleştirme alanını (Placement Area) sahnenin alt kısmında belirledim ve kullanıcıya alanın doluluk durumunu göstermek için renk değişimi gibi görsel efektler ekledim.

Sahneye küp, küre ve zar gibi çeşitli 3D nesneler ekledim. Bu nesnelerin fareyle hareket ettirilebilmesi için fizik motoru (Rigidbody) ve çarpışma algılama sistemi (Collider) ayarlarını yaptım. Ayrıca, bu nesnelere “Draggable” etiketi atayarak sürükleme işlevselliğini tanımladım.

Nesnelerin fareyle sürüklenip hareket ettirilmesi için **DragObject** adlı bir script geliştirdim. Bu script, fareye tıklanıldığında nesneyi seçiyor, sürükleme sırasında nesnenin pozisyonunu fare hareketlerine göre güncelliyor ve fare bırakıldığında nesnenin serbest kalmasını sağlıyor. Fizik motoruyla birlikte çalışarak nesnelerin hareketlerini doğal hale getirdim.

Yerleştirme alanını kontrol etmek için ise **PlacementAreaControl** adında bir script yazdım. Bu script, yerleştirme alanına yalnızca bir nesnenin bırakılabilmesini sağladı. Eğer alan doluyken başka bir nesne yerleştirilmeye çalışılırsa, bu nesne reddedilerek alan dışına taşınıyor. Ayrıca, yerleştirme alanının doluluk durumunu belirtmek için renk değişimi ekledim; alan boşken kırmızı, doluyken yeşil görünüyor.

Projeyi geliştirirken Unity’nin temel özelliklerini kullanarak işlevsel ve estetik bir yapı oluşturdum.
