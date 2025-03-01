#ifndef KUYRUK_HPP
#define KUYRUK_HPP

class DugumKuyruk {
public:
    void* veri; 
    DugumKuyruk* sonraki;

    DugumKuyruk(void* veri);
};

class Kuyruk {
private:
    DugumKuyruk* on;
    DugumKuyruk* arka;
    int boyut;

public:
    Kuyruk();
    ~Kuyruk();

    bool ekle(void* veri);
    void* getir(bool& hataDurumu);
    bool cikar();
    bool bosMu() const;
    int uzunluk() const;
};

#endif
