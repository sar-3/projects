/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			        BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				    PROGRAMLAMAYA GİRİŞİ DERSİ
**
**				ÖDEV NUMARASI…...: 01
**				ÖĞRENCİ ADI...............: SARE NUR KEYHİDAR
**				ÖĞRENCİ NUMARASI.:G231210012
**				DERS GRUBU…………:1A
****************************************************************************/


#include <iostream>
#include <iomanip>
#include <string>
#include <sstream>
#include <cstdlib>
#include <ctime>
#include <locale>
#include <limits>

using namespace std;

struct Urun {
    string isim;
    int stok_miktari;
    double alis_fiyati;
    double satis_fiyati;
    double kdv_orani;
    int satilan_miktar;
};

struct Masraf {
    double kira;
    double personel;
    double elektrik;
    double su;
    double diger;
};

const int MAX_URUN = 20;
const double aylik_giderler = 100000.00; 
const int YILIN_AYLARI = 12;



void urunleriParseEt(const string& firmaurun, Urun urunler[], int& urun_sayisi) {
    stringstream ss(firmaurun);
    string parca;
    urun_sayisi = 0;

    while (getline(ss, parca, ',')) {
        Urun urun;
        urun.isim = parca;

        if (getline(ss, parca, ',')) {
            urun.stok_miktari = stoi(parca);
        }

        if (getline(ss, parca, ',')) {
            urun.alis_fiyati = stod(parca);
        }

        double kar_orani = (rand() % 21 + 30) / 100.0;
        urun.kdv_orani = (rand() % 20) + 1;
        urun.satis_fiyati = urun.alis_fiyati * (1 + kar_orani) * (1 + urun.kdv_orani / 100.0);

        urunler[urun_sayisi++] = urun;
    }
}

void aylikSatisVeStokGuncelle(Urun urunler[], int urun_sayisi) {
    for (int i = 0; i < urun_sayisi; ++i) {
        Urun& urun = urunler[i];

        urun.alis_fiyati *= 1.05;

        double kar_orani = (rand() % 21 + 30) / 100.0;
        urun.satis_fiyati = urun.alis_fiyati * (1 + kar_orani) * (1 + urun.kdv_orani / 100.0);

        int min_satis = urun.stok_miktari * 0.60;
        int max_satis = urun.stok_miktari * 0.80;
        urun.satilan_miktar = min_satis + (rand() % (max_satis - min_satis + 1));

        int kalan_stok = urun.stok_miktari - urun.satilan_miktar;

        int yeni_stok_ekle = (urun.satilan_miktar * (70 + rand() % 31)) / 100;
        urun.stok_miktari = 2 * kalan_stok + yeni_stok_ekle;
    }
}

void aylikIstatistikHesapla(const Urun urunler[], int urun_sayisi) {
    const Urun* en_cok_satan = &urunler[0];
    const Urun* en_az_satan = &urunler[0];
    const Urun* en_cok_kar_eden = &urunler[0];
    const Urun* en_az_kar_eden = &urunler[0];

    double max_kar = 0;
    double min_kar = numeric_limits<double>::infinity();

    for (int i = 0; i < urun_sayisi; ++i) {
        const Urun& urun = urunler[i];

        if (urun.satilan_miktar > en_cok_satan->satilan_miktar) {
            en_cok_satan = &urun;
        }

        if (urun.satilan_miktar < en_az_satan->satilan_miktar) {
            en_az_satan = &urun;
        }

        double kar = (urun.satis_fiyati - urun.alis_fiyati) * urun.satilan_miktar;

        if (kar > max_kar) {
            en_cok_kar_eden = &urun;
            max_kar = kar;
        }

        if (kar < min_kar) {
            en_az_kar_eden = &urun;
            min_kar = kar;
        }
    }

    cout << "\n--- Aylık İstatistikler ---\n";
    cout << "En Çok Satılan Ürün: " << en_cok_satan->isim << " (" << en_cok_satan->satilan_miktar << " adet satıldı)\n";
    cout << "En Az Satılan Ürün: " << en_az_satan->isim << " (" << en_az_satan->satilan_miktar << " adet satıldı)\n";
    cout << "En Çok Kar Elde Edilen Ürün: " << en_cok_kar_eden->isim << " (Kar: " << fixed << setprecision(2) << max_kar << " TL)\n";
    cout << "En Az Kar Elde Edilen Ürün: " << en_az_kar_eden->isim << " (Kar: " << fixed << setprecision(2) << min_kar << " TL)\n";
}

void urunleriYazdir(const Urun urunler[], int urun_sayisi, const string& ay) {
    cout << "\n--- " << ay << " Ayı Ürün Tablosu ---\n";
    cout << left << setw(25) << "Ürün İsmi"
        << setw(15) << "Stok Miktarı"
        << setw(15) << "Alış Fiyatı"
        << setw(15) << "Satış Fiyatı"
        << setw(10) << "KDV Oranı"
        << setw(15) << "Satılan Miktar"
        << setw(20) << "Günlük Ortalama" << endl;
    cout << string(110, '-') << endl;

    for (int i = 0; i < urun_sayisi; ++i) {
        const Urun& urun = urunler[i];
        double gunluk_ortalama = urun.satilan_miktar / 30.0;
        cout << left << setw(25) << urun.isim
            << setw(15) << urun.stok_miktari
            << setw(15) << fixed << setprecision(2) << urun.alis_fiyati
            << setw(15) << urun.satis_fiyati
            << setw(5) << urun.kdv_orani << "%"
            << setw(7) << ""
            << setw(15) << urun.satilan_miktar
            << setw(20) << fixed << setprecision(2) << gunluk_ortalama << endl;
    }
}

double toplamMasrafHesapla(const Masraf& masraf) {
    return masraf.kira + masraf.personel + masraf.elektrik + masraf.su + masraf.diger;
}

void aylikKarHesapla(const Urun urunler[], int urun_sayisi, const Masraf& masraf, const string& ay) {
    double toplam_satis_kari = 0;

    for (int i = 0; i < urun_sayisi; ++i) {
        const Urun& urun = urunler[i];
        double urun_kari = (urun.satis_fiyati - urun.alis_fiyati) * urun.satilan_miktar;
        toplam_satis_kari += urun_kari;
    }

    double toplam_gider = masraf.kira + masraf.personel + masraf.elektrik + masraf.su + masraf.diger;
    double aylik_kar = toplam_satis_kari - toplam_gider;

    cout << "\n--- " << ay << " Ayı Finansal Durum ---\n";
    cout << "Toplam Satış Kârı: " << fixed << setprecision(2) << toplam_satis_kari << " TL\n";
    cout << "Toplam Giderler: " << toplam_gider << " TL\n";
    cout << "Toplam Kâr: " << aylik_kar << " TL\n";
}

void masraflariAl(Masraf& masraf) {
    cout << "\n--- Masraf Bilgilerini Giriniz ---\n";

    do {
        cout << "Kira Masrafı: ";
        cin >> masraf.kira;
        if (cin.fail() || masraf.kira < 0) {
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            cout << "Lütfen geçerli bir sayı giriniz ve sıfırdan küçük olamaz.\n";
        }
    } while (masraf.kira < 0);

    do {
        cout << "Personel Masrafı: ";
        cin >> masraf.personel;
        if (cin.fail() || masraf.personel < 0) {
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            cout << "Lütfen geçerli bir sayı giriniz ve sıfırdan küçük olamaz.\n";
        }
    } while (masraf.personel < 0);

    do {
        cout << "Elektrik Masrafı: ";
        cin >> masraf.elektrik;
        if (cin.fail() || masraf.elektrik < 0) {
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            cout << "Lütfen geçerli bir sayı giriniz ve sıfırdan küçük olamaz.\n";
        }
    } while (masraf.elektrik < 0);

    do {
        cout << "Su Masrafı: ";
        cin >> masraf.su;
        if (cin.fail() || masraf.su < 0) {
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            cout << "Lütfen geçerli bir sayı giriniz ve sıfırdan küçük olamaz.\n";
        }
    } while (masraf.su < 0);

    do {
        cout << "Diğer Masraflar: ";
        cin >> masraf.diger;
        if (cin.fail() || masraf.diger < 0) {
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            cout << "Lütfen geçerli bir sayı giriniz ve sıfırdan küçük olamaz.\n";
        }
    } while (masraf.diger < 0);
}


void yillikRapor(Urun urunler[], int urun_sayisi) {
    string aylar[] = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran",
                       "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };

    Masraf aylik_masraf;
    masraflariAl(aylik_masraf);

    for (const string& ay : aylar) {
        aylikSatisVeStokGuncelle(urunler, urun_sayisi);
        urunleriYazdir(urunler, urun_sayisi, ay);
        aylikIstatistikHesapla(urunler, urun_sayisi);
        aylikKarHesapla(urunler, urun_sayisi, aylik_masraf, ay);
    }
}

void yillikOzet(const Urun urunler[], int urun_sayisi) {
    const Urun* toplam_en_cok_satan = &urunler[0];
    const Urun* toplam_en_az_satan = &urunler[0];
    const Urun* toplam_en_cok_kar_eden = &urunler[0];
    const Urun* toplam_en_az_kar_eden = &urunler[0];

    double toplam_yillik_kar = 0;
    double max_kar = 0;
    double min_kar = numeric_limits<double>::infinity();

    for (int i = 0; i < urun_sayisi; ++i) {
        const Urun& urun = urunler[i];

        // Yıllık toplam kar hesapla
        double toplam_urun_kari = (urun.satis_fiyati - urun.alis_fiyati) * urun.satilan_miktar;
        toplam_yillik_kar += toplam_urun_kari;

        // En çok ve en az satan ürün
        if (urun.satilan_miktar > toplam_en_cok_satan->satilan_miktar) {
            toplam_en_cok_satan = &urun;
        }
        if (urun.satilan_miktar < toplam_en_az_satan->satilan_miktar) {
            toplam_en_az_satan = &urun;
        }

        // En çok ve en az kar getiren ürün
        if (toplam_urun_kari > max_kar) {
            toplam_en_cok_kar_eden = &urun;
            max_kar = toplam_urun_kari;
        }
        if (toplam_urun_kari < min_kar) {
            toplam_en_az_kar_eden = &urun;
            min_kar = toplam_urun_kari;
        }
    }

    // Yıllık özet bilgilerini yazdır
    cout << "\n------------------------ Yıl Sonu Özeti ------------------------\n";
    cout << "Toplam Yıllık Kar: " << fixed << setprecision(2) << toplam_yillik_kar << " TL\n";
    cout << "En Çok Satılan Ürün: " << toplam_en_cok_satan->isim << " (" << toplam_en_cok_satan->satilan_miktar << " adet satıldı)\n";
    cout << "En Az Satılan Ürün: " << toplam_en_az_satan->isim << " (" << toplam_en_az_satan->satilan_miktar << " adet satıldı)\n";
    cout << "En Çok Kar Getiren Ürün: " << toplam_en_cok_kar_eden->isim << " (Kar: " << max_kar << " TL)\n";
    cout << "En Az Kar Getiren Ürün: " << toplam_en_az_kar_eden->isim << " (Kar: " << min_kar << " TL)\n";
}




int main() {
    setlocale(LC_ALL, "Turkish");
    srand(static_cast<unsigned>(time(0)));

    string firmaurun = "mouse,250,51.00,mikrofon,300,89.50,cep telefonu,400,66.40,masaüstü bilgisayar,150,45.09,"
        "laptop,480,96.50,klavye,220,15.75,hoparlör,330,25.30,tablet,310,120.80,kulaklık,290,18.40,"
        "webcam,210,49.99,şarj cihazı,160,10.50,usb kablo,110,5.00,hard disk,370,80.25,ssd,320,100.40,"
        "grafik kartı,420,300.75,işlemci,280,200.00,ram,340,75.90,monitör,430,150.50,kasa,180,90.60,"
        "power supply,270,60.40";

    Urun urunler[MAX_URUN];
    int urun_sayisi;
    urunleriParseEt(firmaurun, urunler, urun_sayisi);
    yillikRapor(urunler, urun_sayisi);
    yillikOzet(urunler, urun_sayisi);

    system("pause");
    return 0;
}