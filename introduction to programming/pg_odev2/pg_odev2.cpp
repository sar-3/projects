/****************************************************************************
**                               SAKARYA ÜNİVERSİTESİ
**                     BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                          BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                            PROGRAMLAMAYA GİRİŞİ DERSİ
**
**                     ÖDEV NUMARASI......: 2
**                     ÖĞRENCİ ADI........: Sare Nur Keyhidar
**                     ÖĞRENCİ NUMARASI...: G2312010012
**                     DERS GRUBU.........: 1A
****************************************************************************/
#include <iostream>
#include <cstdlib>
#include <iomanip>
#include <ctime>

using namespace std;

class Tavuk {
private:
    int yumurtlamaSayaci;
    int toplamYumurta;
    int gunSayaci;

public:
    Tavuk() : yumurtlamaSayaci(0), toplamYumurta(0), gunSayaci(0) {}

    void yumurtla();
    bool kesimZamani() const;
    int getToplamYumurta() const;
    void yemYe(double& yemAmbari);
    void yeniTavukAl();
};

void Tavuk::yumurtla() {
    if (gunSayaci < 3) {
        gunSayaci++;
        return;
    }
    int yumurta = rand() % 3;
    toplamYumurta += yumurta;
    yumurtlamaSayaci = (yumurta == 0) ? yumurtlamaSayaci + 1 : 0;
}

bool Tavuk::kesimZamani() const {
    return yumurtlamaSayaci >= 3 || toplamYumurta >= 100;
}

int Tavuk::getToplamYumurta() const {
    return toplamYumurta;
}

void Tavuk::yemYe(double& yemAmbari) {
    double tuketim = 100 + (rand() % 21);  
    yemAmbari -= tuketim; 
}

void Tavuk::yeniTavukAl() {
    toplamYumurta = 0;
    gunSayaci = 0;
    yumurtlamaSayaci = 0;
}

class Ciftlik {
private:
    double kalanPara;
    int tavukSayisi;
    double yemKgFiyati;
    double yumurtaFiyati;
    double tavukAlimFiyati;
    double yemAmbari;  
    Tavuk* tavuklar;

public:
    Ciftlik(double sermaye, int tavukSayisi, double yemFiyat, double yumurtaFiyat, double alimFiyat);
    ~Ciftlik();
    void simulasyonYap(int gunSayisi);
    int toplamYumurtaSayisi() const;
};

Ciftlik::Ciftlik(double sermaye, int tavukSayisi, double yemFiyat, double yumurtaFiyat, double alimFiyat)
    : kalanPara(sermaye), tavukSayisi(tavukSayisi), yemKgFiyati(yemFiyat),
    yumurtaFiyati(yumurtaFiyat), tavukAlimFiyati(alimFiyat), yemAmbari(700000) { 
    tavuklar = new Tavuk[tavukSayisi];

    kalanPara -= tavukSayisi * tavukAlimFiyati;
    kalanPara -= yemAmbari * yemKgFiyati / 1000.0;  
}

Ciftlik::~Ciftlik() {
    delete[] tavuklar;
}

int Ciftlik::toplamYumurtaSayisi() const {
    int toplam = 0;
    for (int i = 0; i < tavukSayisi; ++i) {
        toplam += tavuklar[i].getToplamYumurta();
    }
    return toplam;
}

void Ciftlik::simulasyonYap(int gunSayisi) {
    for (int gun = 1; gun <= gunSayisi; ++gun) {
        double gunlukGelir = 0.0;
        double gunlukGider = 0.0;
        double toplamYemTuketimi = 0.0;
        int toplamKesilenTavuk = 0;

        for (int i = 0; i < tavukSayisi; ++i) {
            double oncekiYem = yemAmbari;
            tavuklar[i].yemYe(yemAmbari);  
            toplamYemTuketimi += (oncekiYem - yemAmbari);
            tavuklar[i].yumurtla();  
        }

        for (int i = 0; i < tavukSayisi; ++i) {
            gunlukGelir += tavuklar[i].getToplamYumurta() * yumurtaFiyati; 
            if (tavuklar[i].kesimZamani()) {
                toplamKesilenTavuk++;
                gunlukGelir += tavukAlimFiyati / 2; 
                kalanPara -= tavukAlimFiyati; 
                tavuklar[i].yeniTavukAl(); 
            }
        }

        if (yemAmbari < 70000) {  
            yemAmbari += 700000;  
            gunlukGider += 700000 * yemKgFiyati / 1000.0; 
        }

        kalanPara += gunlukGelir - gunlukGider;

        cout << left << setw(5) << gun
            << setw(15) << static_cast<int>(toplamYemTuketimi)
            << setw(10) << toplamYumurtaSayisi()
            << setw(15) << toplamKesilenTavuk
            << setw(15) << fixed << setprecision(2) << gunlukGelir
            << setw(15) << gunlukGider
            << setw(15) << fixed << setprecision(0) << yemAmbari
            << setw(15) << fixed << setprecision(2) << kalanPara << endl;

        if (kalanPara <= 0) {
            cout << "İflas ettiniz..." << endl;
            break;
        }
    }
}

int main() {
    setlocale(LC_ALL, "Turkish");
    srand(static_cast<unsigned>(time(0)));

    double sermaye, yemFiyati, yumurtaFiyati, alimFiyati;
    int tavukSayisi, gunSayisi;

    cout << "Başlangıç sermayesi: ";
    cin >> sermaye;

    do {
        cout << "Tavuk sayısı (500'den fazla olamaz): ";
        cin >> tavukSayisi;
        if (tavukSayisi > 500) {
            cout << "Hata: Tavuk sayısı 500'den fazla olamaz! Lütfen tekrar girin.\n";
        }
    } while (tavukSayisi > 500);

    cout << "Yem kilogram fiyatı: ";
    cin >> yemFiyati;
    cout << "Yumurta fiyatı: ";
    cin >> yumurtaFiyati;
    cout << "Tavuk alım fiyatı: ";
    cin >> alimFiyati;
    cout << "Simülasyon yapılacak gün sayısı: ";
    cin >> gunSayisi;

    Ciftlik ciftlik(sermaye, tavukSayisi, yemFiyati, yumurtaFiyati, alimFiyati);

    cout << left << setw(5) << "Gün"
        << setw(15) << "Yem Tüketimi (g)"
        << setw(10) << "Yumurta"
        << setw(15) << "Kesilen Tavuk"
        << setw(15) << "Günlük Gelir"
        << setw(15) << "Günlük Gider"
        << setw(15) << "Kalan Yem (g)"
        << setw(15) << "Kalan Para" << endl;

    ciftlik.simulasyonYap(gunSayisi);

    system("pause");

    return 0;
}
