package StudentInformation;
public class Student {
    String name,stuNo;
    int classes;
    Course mat;
    Course fizik;
    Course kimya;
    Course smat;
    Course sfizik;
    Course skimya;
    double avarage;
    boolean isPass;
    Student(String name, int classes, String stuNo, Course mat,Course fizik,Course kimya, Course smat,Course sfizik,Course skimya) {
        this.name = name;
        this.classes = classes;
        this.stuNo = stuNo;
        this.mat = mat;
        this.fizik = fizik;
        this.kimya = kimya;
        this.smat = smat;
        this.sfizik = sfizik;
        this.skimya = skimya;
        calcAvarage();
        this.isPass = false;
    }
    public void addBulkExamNote(int mat, int fizik, int kimya,int smat, int sfizik, int skimya) {

        if (mat >= 0 && mat <= 100) {
            this.mat.note = mat;
        }
        if (smat >= 0 && smat <= 100) {
            this.smat.note =smat;
        }

        if (fizik >= 0 && fizik <= 100) {
            this.fizik.note = fizik;
        }
        if (sfizik >= 0 && sfizik <= 100) {
            this.sfizik.note = sfizik;
        }

        if (kimya >= 0 && kimya <= 100) {
            this.kimya.note = kimya;
        }
        if (skimya >= 0 && skimya <= 100) {
            this.skimya.note = skimya;
        }

    }

    public void isPass() {
        if (this.mat.note == 0 || this.fizik.note == 0 || this.kimya.note == 0) {
            System.out.println("Notlar tam olarak girilmemiş");
        } else {
            this.isPass = isCheckPass();
            printNote();
            System.out.println("Ortalama : " + this.avarage);
            if (this.isPass) {
                System.out.println("Sınıfı Geçti. ");
            } else {
                System.out.println("Sınıfta Kaldı.");
            }
        }
    }

    public void calcAvarage() {
        this.avarage = (this.fizik.note + this.kimya.note + this.mat.note) / 3;
    }

    public boolean isCheckPass() {
        calcAvarage();
        return this.avarage > 55;
    }
    public void lessonAverage() {
        this.avarage = (((this.fizik.note * 0.8) + (this.sfizik.note * 0.2)) +
                ((this.mat.note * 0.8) + (this.smat.note)) +
                ((this.kimya.note * 0.8) + (this.skimya.note))) / 3;

    }

    public void printNote(){
        System.out.println("=========================");
        System.out.println("Öğrenci : " + this.name);
        System.out.println("Matematik Notu : " + this.mat.note);
        System.out.println("Matematik Sözlü Notu : " + this.smat.note);
        System.out.println("Fizik Notu : " + this.fizik.note);
        System.out.println("Fizik Sözlü Notu : " + this.sfizik.note);
        System.out.println("Kimya Notu : " + this.kimya.note);
        System.out.println("Kimya Sözlü Notu : " + this.skimya.note);
    }

}