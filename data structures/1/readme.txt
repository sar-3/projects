# Proje Açıklaması

Bu proje, DNA, Kromozom ve Gen sınıflarını kullanarak genetik algoritmalar üzerinde işlemler yapmayı amaçlamaktadır. Proje, C++ dilinde yazılmıştır ve çeşitli genetik işlemleri gerçekleştirebilen bir DNA sınıfı içermektedir.

## Dosya Açıklamaları

### main.cpp
Bu dosya, programın giriş noktasıdır. Kullanıcıdan çeşitli genetik işlemleri seçmesini isteyen bir menü içerir ve bu işlemleri DNA sınıfı üzerinde gerçekleştirir.

### DNA.hpp ve DNA.cpp
DNA sınıfı, bir dizi kromozom içerir ve bu kromozomlar üzerinde çeşitli işlemler yapabilir. Bu işlemler arasında çaprazlama, mutasyon, dosyadan okuma ve yazdırma gibi işlemler bulunmaktadır.

### Kromozom.hpp ve Kromozom.cpp
Kromozom sınıfı, bir dizi gen içerir ve bu genler üzerinde çeşitli işlemler yapabilir. Bu işlemler arasında gen ekleme, gen sayısını hesaplama, bölme ve ekleme, mutasyon ve yazdırma gibi işlemler bulunmaktadır.

### Gen.hpp ve Gen.cpp
Gen sınıfı, bir dizi düğüm içerir ve bu düğümler üzerinde çeşitli işlemler yapabilir. Bu işlemler arasında gen ekleme ve yazdırma gibi işlemler bulunmaktadır.

### Dugum.hpp
Dugum sınıfı, gen ve kromozom sınıflarında kullanılan temel veri yapısını temsil eder. Her düğüm bir veri ve bir sonraki düğüme işaretçi içerir.

## Kullanım

1. Projeyi derlemek için aşağıdaki komutu kullanın: mingw32-make


2. Programı çalıştırmak için aşağıdaki komutu kullanın:./bin/Program


3. Program çalıştığında, kullanıcıdan çeşitli genetik işlemleri seçmesini isteyen bir menü görüntülenecektir. İlgili işlemi seçerek DNA üzerinde çeşitli genetik işlemler gerçekleştirebilirsiniz.

## İşlemler

- **Çaprazlama:** İki kromozom arasında çaprazlama işlemi gerçekleştirir.
- **Mutasyon:** Belirli bir kromozom ve gen üzerinde mutasyon işlemi gerçekleştirir.
- **Otomatik İşlemler:** Bir dosyadan otomatik olarak işlemleri okur ve gerçekleştirir.
- **Ekrana Yazdır:** Kromozomların belirli genlerini ekrana yazdırır.
- **Tüm Popülasyonu Göster:** DNA popülasyonunu ekrana yazdırır.
- **Çıkış:** Programdan çıkar.

## Dosya Yapısı

- `src/`: Kaynak kod dosyaları
- `include/`: Başlık dosyaları
- `bin/`: Derlenmiş ikili dosyalar
- `lib/`: Derlenmiş nesne dosyaları

