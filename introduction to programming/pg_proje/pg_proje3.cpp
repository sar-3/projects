/****************************************************************************
**				   SAKARYA ÜNİVERSİTESİ
**				   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				   BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   PROGRAMLAMAYA GİRİŞ DERSİ
**				   2024-2025 BAHAR DÖNEMİ
**
**				ÖDEV NUMARASI..........:1.proje
**				ÖĞRENCİ ADI............:Sare Nur Keyhidar
**				ÖĞRENCİ NUMARASI.......:G231210012
**              DERSİN ALINDIĞI GRUP...:1A
****************************************************************************/
#include <iostream>
#include <fstream>
#include <sstream>
#include <string>
#include <cstdio>
#include <algorithm>
#include <iomanip>
#include <cctype> 
#include <ctime>
#include <chrono>

using namespace std;

class Mekan {
protected:
    string tur;
    int numara;
    string blok; 

public:
    Mekan(string t, int n, string b) : tur(t), numara(n), blok(b) {}

    virtual void yaz() {
        cout << "Mekan Türü: " << tur << ", Numara: " << numara << ", Blok: " << blok << endl;
    }

    string getTur() { return tur; }
    int getNumara() { return numara; }
    string getBlok() { return blok; }
};

class Daire : public Mekan {
public:
    Daire(int n, string b) : Mekan("Daire", n, b) {}

    void yaz() override {
        cout << "Daire - Numara: " << numara << ", Blok: " << blok << endl;
    }
};

class Fitness : public Mekan {
public:
    Fitness(int n, string b) : Mekan("Fitness", n, b) {}

    void yaz() override {
        cout << "Fitness - Numara: " << numara << ", Blok: " << blok << endl;
    }
};

class Havuz : public Mekan {
public:
    Havuz(int n, string b) : Mekan("Havuz", n, b) {}

    void yaz() override {
        cout << "Havuz - Numara: " << numara << ", Blok: " << blok << endl;
    }
};

class Oturan {
protected:
    string adSoyad;
    string tip;
    int daireNumara;
    double borc;

public:
    Oturan(string ad, string t, int d, double b) : adSoyad(ad), tip(t), daireNumara(d), borc(b) {}

    virtual void yaz() {
        cout << "Adı: " << adSoyad << ", Tipi: " << tip << ", Daire No: " << daireNumara << ", Borç: " << borc << endl;
    }

    double getBorc() { return borc; }
    int getDaireNumara() { return daireNumara; }
    string getTip() { return tip; }
    string getAdSoyad() { return adSoyad; }
};

class AileReisi : public Oturan {
public:
    AileReisi(string ad, int d, double b) : Oturan(ad, "AileReisi", d, b) {}
};

class Misafir : public Oturan {
public:
    Misafir(string ad, int d) : Oturan(ad, "Misafir", d, 0) {}  
};

void mekanYaz(Mekan* mekan) {
    ofstream dosya("Mekan.txt", ios::app);  // Dosyaya ekleme
    if (dosya.is_open()) {
        dosya << mekan->getTur() << "," << mekan->getNumara() << "," << mekan->getBlok() << endl;
        dosya.close();
    }
    else {
        cout << "Dosya açılamadı!" << endl;
    }
}

void mekanOku() {
    ifstream dosya("Mekan.txt");
    string satir;
    if (dosya.is_open()) {
        while (getline(dosya, satir)) {
            stringstream ss(satir);
            string tur, blok;
            int numara;

            getline(ss, tur, ',');
            ss >> numara;
            ss.ignore();
            getline(ss, blok);
        }
        dosya.close();
    }
    else {
        cout << "Dosya açılamadı!" << endl;
    }
}

void oturanYaz(Oturan* oturan) {
    ofstream dosya("Data.txt", ios::app);  

    if (!dosya.is_open()) {
        cout << "Dosya acilamadi!" << endl;
        return;
    }

    if (dynamic_cast<AileReisi*>(oturan)) {
        dosya << oturan->getTip() << ","
            << oturan->getAdSoyad() << ","
            << oturan->getDaireNumara() << ","
            << oturan->getBorc() << endl;
    }
    else if (dynamic_cast<Misafir*>(oturan)) {
        dosya << oturan->getTip() << ","
            << oturan->getAdSoyad() << ","
            << oturan->getDaireNumara() << ",0" << endl;
    }

    dosya.close();
}

void oturanOku() {
    ifstream dosya("Data.txt");
    string satir;

    if (!dosya.is_open()) {
        cout << "Dosya açılmadı!" << endl;
        return;
    }

    while (getline(dosya, satir)) {
        stringstream ss(satir);
        string tip, adSoyad;
        int daireNumara;
        double borc;

        getline(ss, tip, ',');
        getline(ss, adSoyad, ',');
        ss >> daireNumara;
        ss.ignore(); 
        ss >> borc;

        if (tip == "AileReisi") {
            AileReisi aileReisi(adSoyad, daireNumara, borc);
        }
        else if (tip == "Misafir") {
            Misafir misafir(adSoyad, daireNumara);
        }
    }

    dosya.close();
}

void odemeYaz(int daireNumara, double odeme) {
    ofstream dosya("Odeme.txt", ios::app);  // Dosyaya ekleme

    if (dosya.is_open()) {
        dosya << daireNumara << "," << odeme << endl;
        dosya.close();
    }
    else {
        cout << "Dosya acilamadi!" << endl;
    }
}

void odemeOku() {
    ifstream dosya("Odeme.txt");
    string satir;
    if (dosya.is_open()) {
        while (getline(dosya, satir)) {
            stringstream ss(satir);
            int daireNumara;
            double odeme;
            ss >> daireNumara;
            ss.ignore();
            ss >> odeme;
        }
        dosya.close();
    }
    else {
        cout << "Dosya acilamadi!" << endl;
    }
}

void havuzKulYaz(const string& mesaj) {
    ofstream dosya("HavuzKul.txt", ios::app); // Dosyaya ekleme
    if (dosya.is_open()) {
        dosya << mesaj << endl;
        dosya.close();
    }
    else {
        cout << "Dosya acilamadi!" << endl;
    }
}

void havuzKulOku() {
    ifstream dosya("HavuzKul.txt");
    string satir;
    if (dosya.is_open()) {
        while (getline(dosya, satir)) {
            cout << satir << endl;
        }
        dosya.close();
    }
    else {
        cout << "Dosya acilamadi!" << endl;
    }
}

void fitnessKulYaz(string mesaj) {
    ofstream dosya("FitnessKul.txt", ios::app);
    if (dosya.is_open()) {
        dosya << mesaj << endl;
        dosya.close();
    }
    else {
        cout << "Dosya açılamadı!" << endl;
    }
}

void fitnessOku() {
    ifstream dosya("Fitness.txt");
    string satir;
    if (dosya.is_open()) {
        while (getline(dosya, satir)) {
            cout << satir << endl;
        }
        dosya.close();
    }
    else {
        cout << "Dosya acilamadi!" << endl;
    }
}

void mekanEkle() {
    int numara;
    int secim;
    char blok;

    cout << "Mekan Türünü seçin:\n";
    cout << "1. Daire\n";
    cout << "2. Fitness\n";
    cout << "3. Havuz\n";
    cout << "Seçiminizi yapın (1-3): ";
    cin >> secim;

    string tur;
    switch (secim) {
    case 1:
        tur = "Daire";
        break;
    case 2:
        tur = "Fitness";
        break;
    case 3:
        tur = "Havuz";
        break;
    default:
        cout << "Geçersiz seçim!" << endl;
        return;
    }

    cout << "Mekan numarasını girin: ";
    cin >> numara;

    cout << "Blok Türünü seçin (A, B, C): ";
    cin >> blok;

    blok = toupper(blok);
    if (blok != 'A' && blok != 'B' && blok != 'C') {
        cout << "Geçersiz blok! Sadece A, B veya C blokları geçerlidir." << endl;
        return;
    }

    Mekan* mekan = nullptr;
    if (tur == "Daire") {
        mekan = new Daire(numara, string(1, blok));
    }
    else if (tur == "Fitness") {
        mekan = new Fitness(numara, string(1, blok));
    }
    else if (tur == "Havuz") {
        mekan = new Havuz(numara, string(1, blok));
    }

    mekanYaz(mekan);
    cout << tur << " türünde numara " << numara << " ve blok " << blok << " başarıyla eklendi." << endl;

    delete mekan;
}

void mekanSil() {
    int daireNumara;
    string satir;
    string blok;

    ifstream dosya("Mekan.txt");
    if (!dosya.is_open()) {
        cout << "Mekan.txt dosyası açılamadı!" << endl;
        return;
    }

    cout << "Mevcut mekanlar:" << endl;
    int satirNumarasi = 1;  
    while (getline(dosya, satir)) {
        cout << satirNumarasi << ". " << satir << endl;
        satirNumarasi++;
    }
    dosya.close();

    cout << "Silmek istediğiniz mekanın numarasını girin: ";
    cin >> daireNumara;

    ifstream dosyaOku("Mekan.txt");
    ofstream dosyaYaz("Mekan_temp.txt"); 

    if (!dosyaOku.is_open() || !dosyaYaz.is_open()) {
        cout << "Dosya açılamadı!" << endl;
        return;
    }

    bool mekanBulundu = false;
    while (getline(dosyaOku, satir)) {
        stringstream ss(satir);
        string tur, mevcutBlok;
        int mevcutNumara;

        getline(ss, tur, ',');
        ss >> mevcutNumara;
        ss.ignore();  
        getline(ss, mevcutBlok);

        if (mevcutNumara != daireNumara) {
            dosyaYaz << tur << "," << mevcutNumara << "," << mevcutBlok << endl;
        }
        else {
            mekanBulundu = true; 
            blok = mevcutBlok;   
        }
    }

    dosyaOku.close();
    dosyaYaz.close();

    if (mekanBulundu) {
        if (remove("Mekan.txt") != 0) { 
            perror("Dosya silinemedi");
            return;
        }
        if (rename("Mekan_temp.txt", "Mekan.txt") != 0) {  
            perror("Dosya yeniden adlandırılamadı");
            return;
        }
        cout << "Mekan numarası " << daireNumara << " başarıyla silindi." << endl;

        ifstream oturanOku("Data.txt");
        ofstream oturanYaz("Data_temp.txt");  

        if (!oturanOku.is_open() || !oturanYaz.is_open()) {
            cout << "Data.txt dosyası açılamadı!" << endl;
            return;
        }

        bool oturanBulundu = false;
        while (getline(oturanOku, satir)) {
            stringstream ss(satir);
            string tip, adSoyad;
            int daireNumaraOkunan;
            double borc;

            getline(ss, tip, ',');
            getline(ss, adSoyad, ',');
            ss >> daireNumaraOkunan;
            ss.ignore(); 
            ss >> borc;

            if (daireNumaraOkunan != daireNumara) {
                oturanYaz << satir << endl;
            }
            else {
                oturanBulundu = true; 
            }
        }

        oturanOku.close();
        oturanYaz.close();

        if (oturanBulundu) {
            if (remove("Data.txt") != 0) {  
                perror("Data.txt dosyası silinemedi");
                return;
            }
            if (rename("Data_temp.txt", "Data.txt") != 0) {  
                perror("Data.txt dosyası yeniden adlandırılamadı");
                return;
            }
            cout << "Bu dairede bir oturan bulundu ve onun kaydı da silindi." << endl;
        }
        else {
            remove("Data_temp.txt"); 
        }
    }
    else {
        cout << "Silinmek istenen mekan numarası bulunamadı!" << endl;
        remove("Mekan_temp.txt"); 
    }
}

void mevcutMekanlariListele() {
    ifstream dosya("Mekan.txt");
    string satir;
    int satirNumarasi = 1;

    if (!dosya.is_open()) {
        cout << "Dosya açılamadı!" << endl;
        return;
    }

    cout << "Mevcut mekanlar:" << endl;
    while (getline(dosya, satir)) {
        cout << satirNumarasi << ". " << satir << endl;
        satirNumarasi++;
    }
    dosya.close();
}

bool mekanVarMi(const string& tur, int numara, const string& blok) {
    ifstream dosya("Mekan.txt");
    string satir;
    if (dosya.is_open()) {
        while (getline(dosya, satir)) {
            stringstream ss(satir);
            string mevcutTur, mevcutBlok;
            int mevcutNumara;
            getline(ss, mevcutTur, ',');
            ss >> mevcutNumara;
            ss.ignore(); 
            getline(ss, mevcutBlok, ',');

            if (mevcutNumara == numara) {
                dosya.close();
                return true;  
            }
        }
        dosya.close();
    }
    return false;
}

bool maksimumLimitKontrolu(const string& tur, const string& blok) {
    ifstream dosya("Mekan.txt");
    string satir;
    int sayac = 0;

    if (dosya.is_open()) {
        while (getline(dosya, satir)) {
            stringstream ss(satir);
            string mevcutTur, mevcutBlok;
            int mevcutNumara;
            getline(ss, mevcutTur, ',');
            ss >> mevcutNumara;
            ss.ignore();  
            getline(ss, mevcutBlok, ',');

            if (mevcutTur == tur && mevcutBlok == blok) {
                sayac++;
            }
        }
        dosya.close();
    }

    if (tur == "Fitness" && sayac >= 2) {
        return false; 
    }
    if (tur == "Havuz" && sayac >= 3) {
        return false; 
    }
    if (tur == "Daire" && sayac >= 25) {
        return false;  
    }
    return true;
}

void mekanDuzenle() {
    int satirNumarasi, yeniNumara;
    string yeniTur, yeniBlok, satir;

    mevcutMekanlariListele();

    cout << "Düzenlemek istediğiniz mekanın satır numarasını girin: ";
    cin >> satirNumarasi;

    ifstream dosyaOku("Mekan.txt");
    ofstream dosyaYaz("Mekan_temp.txt"); 

    if (!dosyaOku.is_open() || !dosyaYaz.is_open()) {
        cout << "Dosya açılamadı!" << endl;
        return;
    }

    int currentLine = 1;
    bool mekanBulundu = false;

    while (getline(dosyaOku, satir)) {
        if (currentLine == satirNumarasi) {
            stringstream ss(satir);
            string tur, blok;
            int numara;
            getline(ss, tur, ',');
            ss >> numara;
            ss.ignore();
            getline(ss, blok, ',');

            cout << "Mevcut mekan --> Türü: " << tur << " Numarası: " << numara << " Blok: " << blok << endl;
            cout << "Yeni mekan türünü seçin (1: Daire, 2: Fitness, 3: Havuz): ";
            int secim;
            cin >> secim;

            switch (secim) {
            case 1:
                yeniTur = "Daire";
                break;
            case 2:
                yeniTur = "Fitness";
                break;
            case 3:
                yeniTur = "Havuz";
                break;
            default:
                cout << "Geçersiz seçenek!" << endl;
                dosyaOku.close();
                dosyaYaz.close();
                return;
            }

            cout << "Yeni mekan numarasını girin: ";
            cin >> yeniNumara;

            cout << "Yeni mekan blok numarasını girin (A, B, C): ";
            cin >> yeniBlok;
            yeniBlok = toupper(yeniBlok[0]);

            if (mekanVarMi(yeniTur, yeniNumara, yeniBlok)) {
                cout << "Bu numarada bir mekan zaten var!" << endl;
                dosyaOku.close();
                dosyaYaz.close();
                return;
            }

            if (!maksimumLimitKontrolu(yeniTur, yeniBlok)) {
                cout << "Bu türdeki mekan için maksimum limit aşıldı ya da bloktaki limit aşıldı!" << endl;
                dosyaOku.close();
                dosyaYaz.close();
                return;
            }

            dosyaYaz << yeniTur << "," << yeniNumara << "," << yeniBlok << endl;

            mekanBulundu = true;
        }
        else {
            dosyaYaz << satir << endl;
        }

        currentLine++;
    }

    dosyaOku.close();
    dosyaYaz.close();

    if (mekanBulundu) {
        if (remove("Mekan.txt") != 0) { 
            perror("Dosya silinemedi");
            return;
        }
        if (rename("Mekan_temp.txt", "Mekan.txt") != 0) { 
            perror("Dosya yeniden adlandırılamadı");
            return;
        }
        cout << "Mekan başarıyla düzenlendi." << endl;
    }
    else {
        cout << "Düzenlemek istenen mekan bulunamadı!" << endl;
        remove("Mekan_temp.txt");  
    }
}

void mekanMenu() {
    int secim;
    while (true) {
        cout << "Mekan Menusu:\n";
        cout << "1. Mekan Ekle\n";
        cout << "2. Mekan Sil\n";
        cout << "3. Mekan Düzenle\n";
        cout << "4. Mekanları Listele\n";
        cout << "5. Geri Dön\n";
        cout << "Seciminizi yapin: ";
        cin >> secim;

        if (secim == 5) return;

        switch (secim) {
        case 1:
            cout << endl;
            mekanOku();
            mekanEkle();
            cout << endl;
            break;
        case 2:
            cout << endl;
            mekanOku();
            oturanOku();
            mekanSil();
            cout << endl;
            break;
        case 3:
            cout << endl;
            mekanOku();
            mekanDuzenle();
            cout << endl;
            break;
        case 4:
            cout << endl;
            mekanOku();
            mevcutMekanlariListele();
            cout << endl;
            break;
        default:
            cout << "Gecersiz secim!" << endl;
            break;
        }
    }
}

void daireNumaralariListele() {
    ifstream dosya("mekan.txt");
    string satir;
    int numara;
    string tur;
    cout << "Mevcut Daire Numaralari: " << endl;
    int sayac = 1;

    while (getline(dosya, satir)) {
        stringstream ss(satir);

        getline(ss, tur, ',');  
        ss >> numara; 

        if (tur != "Fitness" && tur != "Havuz") {
            cout << sayac << ". Daire No: " << numara << endl;
            sayac++;
        }
    }
}

bool daireNumarasiGecerliMi(int daireNumara) {
    ifstream dosya("mekan.txt");
    string satir;
    while (getline(dosya, satir)) {
        stringstream ss(satir);
        string tur;
        int numara;
        getline(ss, tur, ',');
        ss >> numara;

        if (numara == daireNumara) {
            return true; 
        }
    }
    return false;  
}

bool daireVarMi(int daireNumara) {
    ifstream dosya("Data.txt");
    string satir;
    while (getline(dosya, satir)) {
        stringstream ss(satir);
        string tip;
        string adSoyad;
        int mevcutDaireNumara;
        double borc;
        getline(ss, tip, ',');
        getline(ss, adSoyad, ',');  
        ss >> mevcutDaireNumara;
        ss.ignore();
        ss >> borc; 

        if (mevcutDaireNumara == daireNumara) {
            return true; 
        }
    }
    return false;
}

void oturanEkle() {
    string adSoyad;
    string tip;
    int daireNumara;
    double borc;

    cout << "Oturanin adini ve soyadini girin (örnek: Ahmet Yilmaz): ";
    cin.ignore(); 
    getline(cin, adSoyad);  

    daireNumaralariListele();

    while (true) {
        cout << "Bir daire numarasi secin (mekan.txt'teki numaralardan): ";
        cin >> daireNumara;

        if (!daireNumarasiGecerliMi(daireNumara)) {
            cout << "Bu daire numarası mevcut değil! Lütfen geçerli bir daire numarası girin." << endl;
            continue; 
        }

        if (daireVarMi(daireNumara)) {
            cout << "Bu daire numarasında zaten bir oturan var! Lütfen başka bir daire numarası seçin." << endl;
            continue; 
        }

        break;  
    }

    cout << "Oturan tipi (AileReisi / Misafir): " << endl;
    cout << "1. AileReisi" << endl;
    cout << "2. Misafir" << endl;
    cout << "Seçiminizi yapın (1 / 2): ";
    int secim;
    cin >> secim;

    switch (secim) {
    case 1: {
        cout << "Borcu girin: ";
        cin >> borc;
        AileReisi* yeniAileReisi = new AileReisi(adSoyad, daireNumara, borc);
        oturanYaz(yeniAileReisi);
        delete yeniAileReisi;
        cout << "AileReisi başarıyla eklendi!" << endl;
        break;
    }
    case 2: {
        Misafir* yeniMisafir = new Misafir(adSoyad, daireNumara);
        oturanYaz(yeniMisafir);
        delete yeniMisafir;
        cout << "Misafir başarıyla eklendi!" << endl;
        break;
    }
    default:
        cout << "Geçersiz secim!" << endl;
        break;
    }
}

void oturanSil() {
    ifstream dosyaOku("Data.txt");
    if (!dosyaOku.is_open()) {
        cout << "Dosya acilamadi!" << endl;
        return;
    }

    string satir;
    int sayac = 1; 
    stringstream ss;
    string tip, adSoyad;
    int daire;
    double borc;

    cout << "Mevcut Oturanlar: " << endl;
    while (getline(dosyaOku, satir)) {
        ss.clear();
        ss.str(satir);
        getline(ss, tip, ',');
        getline(ss, adSoyad, ','); 
        ss >> daire >> borc;

        cout << sayac << ". Daire No: " << daire
            << ", Tip: " << tip
            << ", Ad Soyad: " << adSoyad
            << ", Borc: " << borc << endl;

        sayac++;
    }

    dosyaOku.close();

    int secim;
    cout << "Silmek istediginiz oturanin numarasini secin: ";
    cin >> secim;

    ifstream dosyaOku2("Data.txt");
    ofstream dosyaYaz("Data_temp.txt"); 
    if (!dosyaOku2.is_open() || !dosyaYaz.is_open()) {
        cout << "Dosya acilamadi!" << endl;
        return;
    }

    sayac = 1;
    bool bulundu = false;
    while (getline(dosyaOku2, satir)) {
        ss.clear();
        ss.str(satir);
        getline(ss, tip, ',');
        getline(ss, adSoyad, ','); 
        ss >> daire >> borc;

        if (sayac != secim) {
            dosyaYaz << satir << endl; 
        }
        else {
            bulundu = true; 
        }
        sayac++;
    }

    dosyaOku2.close();
    dosyaYaz.close();

    if (bulundu) {
        if (remove("Data.txt") != 0) {
            cout << "Dosya silinemedi!" << endl;
            return;
        }
        if (rename("Data_temp.txt", "Data.txt") != 0) {
            cout << "Dosya yeniden adlandirilamadi!" << endl;
            return;
        }
        cout << "Oturani basariyla sildiniz!" << endl;
    }
    else {
        cout << "Böyle bir oturan bulunamadi!" << endl;
    }
}

void oturanDuzenle() {
    ifstream dosyaOku("Data.txt");
    ofstream dosyaYaz("Data_temp.txt");

    if (!dosyaOku.is_open() || !dosyaYaz.is_open()) {
        cout << "Dosya acilamadi!" << endl;
        return;
    }

    string satir;
    int sayac = 1;
    string secilenSatir;
    int secim;
    string tip, adSoyad;
    int daire;
    double borc;

    while (getline(dosyaOku, satir)) {
        stringstream ss(satir);
        getline(ss, tip, ',');
        getline(ss, adSoyad, ',');
        ss >> daire;
        ss.ignore();
        ss >> borc;

        cout << sayac << ". Daire No: " << daire
            << ", Tip: " << tip
            << ", Ad Soyad: " << adSoyad
            << ", Borç: " << borc << endl;
        sayac++;
    }

    cout << "Duzenlemek istediginiz oturanin satir umarasini girin: ";
    cin >> secim;

    if (secim < 1 || secim >= sayac) {
        cout << "Gecersiz secim!" << endl;
        dosyaOku.close();
        dosyaYaz.close();
        return;
    }

    dosyaOku.clear();
    dosyaOku.seekg(0, ios::beg);  // Dosya başına gitmeyi sağlıyor

    sayac = 1;
    while (getline(dosyaOku, satir)) {
        if (sayac == secim) {
            secilenSatir = satir;
            break;
        }
        sayac++;
    }

    stringstream ss(secilenSatir);
    getline(ss, tip, ',');
    getline(ss, adSoyad, ',');
    ss >> daire;
    ss.ignore();
    ss >> borc;

    cout << "Mevcut ad soyad: " << adSoyad << endl;
    cout << "Ad soyadi degistirmek ister misiniz? (1 - Evet, 2 - Hayir): ";
    int secimAdSoyad;
    cin >> secimAdSoyad;

    if (secimAdSoyad == 1) {
        cout << "Yeni ad soyadi girin: ";
        cin.ignore();
        getline(cin, adSoyad);
    }

    if (tip != "Misafir") {
        cout << "Mevcut borcu: " << borc << endl;
        cout << "Borcu degistirmek ister misiniz? (1 - Evet, 2 - Hayir): ";
        int secimBorc;
        cin >> secimBorc;

        if (secimBorc == 1) {
            cout << "Yeni borcu girin: ";
            cin >> borc;
        }
    }
    else {
        cout << "Misafirlerin borcu düzenlenemez." << endl;
    }

    dosyaOku.clear();
    dosyaOku.seekg(0, ios::beg);  // Dosya başına gitmeyi sağlıyor

    sayac = 1;
    while (getline(dosyaOku, satir)) {
        if (sayac == secim) {
            dosyaYaz << tip + "," + adSoyad + "," + to_string(daire) + "," + to_string(borc) << endl;
        }
        else {
            dosyaYaz << satir << endl;
        }
        sayac++;
    }

    dosyaOku.close();
    dosyaYaz.close();

    if (remove("Data.txt") != 0) {
        cout << "Dosya silinemedi!" << endl;
        return;
    }
    if (rename("Data_temp.txt", "Data.txt") != 0) {
        cout << "Dosya yeniden adlandirilemedi!" << endl;
        return;
    }

    cout << "Oturani basariyla duzenlediniz!" << endl;
}

void oturanListele() {
    ifstream dosya("Data.txt");
    string satir;

    if (dosya.is_open()) {
        cout << "Mevcut oturanlar:" << endl;
        while (getline(dosya, satir)) {
            stringstream ss(satir);
            string tip;
            string adSoyad;
            int daireNumara;
            double borc;

            getline(ss, tip, ',');
            getline(ss, adSoyad, ',');
            ss >> daireNumara;  
            ss.ignore();        
            ss >> borc;        

            cout << "Tip: " << tip
                << ", Ad Soyad: " << adSoyad
                << ", Daire No: " << daireNumara
                << ", Borç: " << borc << endl;
        }
        dosya.close();
    }
    else {
        cout << "Dosya acilamadi!" << endl;
    }
}

void oturanMenu() {
    int secim;
    while (true) {
        cout << "--------Oturan Menüsü--------\n";
        cout << "1. Oturan Ekle\n";
        cout << "2. Oturan Sil\n";
        cout << "3. Oturan Düzenle\n";
        cout << "4. Oturanları Listele\n";
        cout << "5. Geri Dön\n";
        cout << "Seçiminizi yapın: ";
        cin >> secim;

        if (secim == 5) return;

        switch (secim) {
        case 1:
            cout << endl;
            mekanOku();
            oturanOku();
            oturanEkle();
            cout << endl;
            break;
        case 2:
            cout << endl;
            oturanOku();
            oturanSil();
            cout << endl;
            break;
        case 3:
            cout << endl;
            oturanOku();
            oturanDuzenle();
            cout << endl;
            break;
        case 4:
            cout << endl;
            oturanOku();
            oturanListele();
            cout << endl;
            break;
        default:
            cout << "Gecersiz secim!" << endl;
            break;
        }
    }
}

void listeyiYazdir() {
    ifstream dosyaOku("Data.txt");
    if (!dosyaOku.is_open()) {
        cout << "Dosya acilamadi!" << endl;
        return;
    }

    string satir;
    cout << "Mevcut daireler ve borçlar:\n";
    while (getline(dosyaOku, satir)) {
        stringstream ss(satir);
        string tip, adSoyad;
        int daire;
        double borc;

        getline(ss, tip, ',');
        getline(ss, adSoyad, ',');
        ss >> daire;
        ss.ignore(); 
        ss >> borc;

        cout << "Daire No: " << daire << ", Borç: " << borc << endl;
    }
    dosyaOku.close();
}

void odemeEkle() {
    int daireNumara;
    double artışMiktari;

    listeyiYazdir();

    cout << "\nBorç artışı yapmak istediginiz dairenin numarasını girin: ";
    cin >> daireNumara;
    cout << "Borç artışı miktarını girin: ";
    cin >> artışMiktari;

    ifstream dosyaOku("Data.txt");
    if (!dosyaOku.is_open()) {
        cout << "Dosya acilamadi!" << endl;
        return;
    }

    string satir;
    stringstream buffer;
    bool guncellendi = false;

    while (getline(dosyaOku, satir)) {
        stringstream ss(satir);
        string tip, adSoyad;
        int daire;
        double borc;

        getline(ss, tip, ',');
        getline(ss, adSoyad, ',');
        ss >> daire;
        ss.ignore(); 
        ss >> borc;

        if (daire == daireNumara) {
            borc += artışMiktari; 
            guncellendi = true;
        }

        buffer << tip << "," << adSoyad << "," << daire << "," << borc << endl;
    }
    dosyaOku.close();

    if (guncellendi) {
        ofstream dosyaYaz("Data.txt");
        if (!dosyaYaz.is_open()) {
            cout << "Dosya acilamadi!" << endl;
            return;
        }
        dosyaYaz << buffer.str();
        dosyaYaz.close();

        ofstream odemeDosya("Odeme.txt", ios::app);
        if (odemeDosya.is_open()) {
            odemeDosya << "Daire No: " << daireNumara
                << ", Eklenen Miktar: " << artışMiktari << endl;
            odemeDosya.close();
        }
        else {
            cout << "\nOdeme.txt dosyasına yazılamadı!" << endl;
        }

        cout << "\nBorç güncellendi!" << endl;
    }
    else {
        cout << "\nBöyle bir daire bulunamadı!" << endl;
    }
}

void odemeSil() {
    int daireNumara;
    double azalisMiktari;

    listeyiYazdir();

    cout << "\nBorç silmek istediginiz dairenin numarasını girin: ";
    cin >> daireNumara;
    cout << "Borçtan eksiltmek istediğiniz miktarını girin: ";
    cin >> azalisMiktari;

    ifstream dosyaOku("Data.txt");
    if (!dosyaOku.is_open()) {
        cout << "Dosya acilamadi!" << endl;
        return;
    }

    string satir;
    stringstream buffer;
    bool guncellendi = false;

    while (getline(dosyaOku, satir)) {
        stringstream ss(satir);
        string tip, adSoyad;
        int daire;
        double borc;

        getline(ss, tip, ',');
        getline(ss, adSoyad, ',');
        ss >> daire;
        ss.ignore(); 
        ss >> borc;

        if (daire == daireNumara) {
            borc -= azalisMiktari; 
            guncellendi = true;
        }

        buffer << tip << "," << adSoyad << "," << daire << "," << borc << endl;
    }
    dosyaOku.close();

    if (guncellendi) {
        ofstream dosyaYaz("Data.txt");
        if (!dosyaYaz.is_open()) {
            cout << "Dosya acilamadi!" << endl;
            return;
        }
        dosyaYaz << buffer.str();
        dosyaYaz.close();

        ofstream odemeDosya("Odeme.txt", ios::app); 
        if (odemeDosya.is_open()) {
            odemeDosya << "Daire No: " << daireNumara
                << ", Azalan Miktar: " << azalisMiktari << endl;
            odemeDosya.close();
        }
        else {
            cout << "\nOdeme.txt dosyasına yazılamadı!" << endl;
        }

        cout << "\nBorç güncellendi!" << endl;
    }
    else {
        cout << "\nBöyle bir daire bulunamadı!" << endl;
    }
}

void odemeRaporu() {
    ifstream odemeDosya("Odeme.txt");
    if (!odemeDosya.is_open()) {
        cout << "Odeme.txt dosyası açılamadı!" << endl;
        return;
    }

    string satir;
    cout << "Ödeme Raporu:\n";
    cout << "-------------------------\n";

    bool bosDosya = true;
    while (getline(odemeDosya, satir)) {
        cout << satir << endl;
        bosDosya = false; // Dosyada en az bir satır olduğunu gösterir
    }

    if (bosDosya) {
        cout << "Odeme.txt dosyasında herhangi bir kayıt bulunmuyor." << endl;
    }

    odemeDosya.close();
}

void odemeMenu() {
    int secim;
    do {
        cout << "\n--- Ödeme Islemleri ---" << endl;
        cout << "1. Ödeme Ekle" << endl;
        cout << "2. Ödeme Sil" << endl;
        cout << "3. Ödeme Raporu" << endl;
        cout << "4. Geri Dön" << endl;
        cout << "Seciminizi yapin: ";
        cin >> secim;

        switch (secim) {
        case 1:
            cout << endl;
            oturanOku();
            odemeOku();
            odemeEkle();
            cout << endl;
            break;
        case 2:
            cout << endl;
            odemeOku();
            odemeSil();
            cout << endl;
            break;
        case 3:
            cout << endl;
            odemeOku();
            odemeRaporu();
            cout << endl;
            break;
        case 4:
            cout << "Geri dönülüyor" << endl;
            break;
        default:
            cout << "Geçersiz seçim! Tekrar deneyin." << endl;
        }
    } while (secim != 4);
}

void dataListele() {
    ifstream dataDosya("Data.txt");
    if (!dataDosya.is_open()) {
        cout << "Data.txt dosyası açılamadı!" << endl;
        return;
    }

    string satir;
    cout << "Daire Listesi ve Borç Durumları:\n";
    cout << "---------------------------------\n";
    while (getline(dataDosya, satir)) {
        stringstream ss(satir);
        string tip, adSoyad;
        int daireNumara;
        double borc;

        getline(ss, tip, ',');
        getline(ss, adSoyad, ',');
        ss >> daireNumara;
        ss.ignore(); // ',' karakterini atla
        ss >> borc;

        cout << "Daire No: " << daireNumara << ", Tip: " << tip
            << ", Ad Soyad: " << adSoyad << ", Borç: " << borc << endl;
    }
    dataDosya.close();
}

void havuzKullan() {
    int daireNumara;

    cout << "\nHavuz kullanım kaydı için daire numarasını seçin: ";
    cin >> daireNumara;

    ifstream dataDosya("Data.txt");
    if (!dataDosya.is_open()) {
        cout << "Data.txt dosyası açılamadı!" << endl;
        return;
    }

    string satir;
    bool daireBulundu = false;
    double borc = 0.0;
    string adSoyad;

    while (getline(dataDosya, satir)) {
        stringstream ss(satir);
        string dosyaTip;
        int daire;
        double mevcutBorc;

        getline(ss, dosyaTip, ',');
        getline(ss, adSoyad, ',');
        ss >> daire;
        ss.ignore();
        ss >> mevcutBorc;

        if (daire == daireNumara) {
            daireBulundu = true;
            borc = mevcutBorc;
            break;
        }
    }
    dataDosya.close();

    if (daireBulundu) {
        time_t now = time(0);
        tm ltm;
        localtime_s(&ltm, &now); 

        stringstream zamanStream;
        zamanStream << 1900 + ltm.tm_year << "-"
            << 1 + ltm.tm_mon << "-"
            << ltm.tm_mday << " "
            << (ltm.tm_hour < 10 ? "0" : "") << ltm.tm_hour << ":"
            << (ltm.tm_min < 10 ? "0" : "") << ltm.tm_min << ":"
            << (ltm.tm_sec < 10 ? "0" : "") << ltm.tm_sec;

        string zaman = zamanStream.str();

        if (borc == 0) {
            cout << "\nHavuz kullanımı kaydedildi: Daire No " << daireNumara << ", Zaman: " << zaman << endl;
        }
        else {
            cout << "\nBorç nedeniyle havuz kullanılamadı: Daire No " << daireNumara << ", Zaman: " << zaman << endl;
        }
    }
    else {
        cout << "\nDaire numarası bulunamadı veya geçersiz." << endl;
    }
}

void fitnessKullan() {
    int daireNumara;

    dataListele();

    cout << "\nFitness kullanım kaydı için daire numarasını seçin: ";
    cin >> daireNumara;

    ifstream dataDosya("Data.txt");
    if (!dataDosya.is_open()) {
        cout << "Data.txt dosyası açılamadı!" << endl;
        return;
    }

    string satir;
    bool daireBulundu = false;
    double borc = 0.0;
    string adSoyad;

    while (getline(dataDosya, satir)) {
        stringstream ss(satir);
        string dosyaTip;
        int daire;
        double mevcutBorc;

        getline(ss, dosyaTip, ',');
        getline(ss, adSoyad, ',');
        ss >> daire;
        ss.ignore();
        ss >> mevcutBorc;

        if (daire == daireNumara) {
            daireBulundu = true;
            borc = mevcutBorc;
            break;
        }
    }
    dataDosya.close();

    if (daireBulundu) {
        time_t now = time(0);
        tm ltm;
        localtime_s(&ltm, &now); 

        stringstream zamanStream;
        zamanStream << 1900 + ltm.tm_year << "-"
            << 1 + ltm.tm_mon << "-"
            << ltm.tm_mday << " "
            << (ltm.tm_hour < 10 ? "0" : "") << ltm.tm_hour << ":"
            << (ltm.tm_min < 10 ? "0" : "") << ltm.tm_min << ":"
            << (ltm.tm_sec < 10 ? "0" : "") << ltm.tm_sec;

        string zaman = zamanStream.str();

        if (borc == 0) {
            fitnessKulYaz("Daire No: " + to_string(daireNumara) + " - Fitness kullanıldı. Zaman: " + zaman);
            cout << "\nFitness kullanımı kaydedildi: Daire No " << daireNumara << ", Zaman: " << zaman << endl;
        }
        else {
            fitnessKulYaz("Daire No: " + to_string(daireNumara) + " - Borç nedeniyle fitness kullanılamadı. Zaman: " + zaman);
            cout << "\nBorç nedeniyle fitness kullanılamadı: Daire No " << daireNumara << ", Zaman: " << zaman << endl;
        }
    }
    else {
        cout << "\nDaire numarası bulunamadı veya geçersiz." << endl;
    }
}

int main() {
    setlocale(LC_ALL, "Turkish");
    int anaSecim;
    while (true) {
        cout << "---------ANA MENÜ---------\n";
        cout << "1. Mekan İşlemleri\n";
        cout << "2. Oturan İşlemleri\n";
        cout << "3. Ödeme İşlemleri\n";
        cout << "4. Havuz Kullanma İşlemleri\n";
        cout << "5. Fitness Kullanma İşlemleri\n";
        cout << "6. Çıkış\n";
        cout << "Seçimizi Yapınız: ";
        cin >> anaSecim;

        switch (anaSecim) {
        case 1:
            cout << endl;
            mekanMenu();
            cout << endl;
            break;
        case 2:
            cout << endl;
            oturanMenu();
            cout << endl;
            break;
        case 3:
            cout << endl;
            odemeMenu();
            cout << endl;
            break;
        case 4:
            cout << endl;
            oturanOku();
            havuzKullan();
            cout << endl;
            break;
        case 5:
            cout << endl;
            oturanOku();
            fitnessKullan();
            cout << endl;
            break;
        case 6:
            cout << "Programdan çıkılıyor..." << endl;
            return 0;
        default:
            cout << "Geçersiz seçim!" << endl;
            cout << endl;
            break;
        }
    }

    return 0;
}