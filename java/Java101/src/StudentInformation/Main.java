package StudentInformation;

public class Main {
    public static void main(String[] args) {

        Course mat = new Course("Matematik", "MAT101", "MAT");
        Course fizik = new Course("Fizik", "FZK101", "FZK");
        Course kimya = new Course("Kimya", "KMY101", "KMY");
        Course smat = new Course("Matematik", "MAT101", "MAT");
        Course sfizik = new Course("Fizik", "FZK101", "FZK");
        Course skimya = new Course("Kimya", "KMY101", "KMY");

        Teacher t1 = new Teacher("Mahmut Hoca", "90550000000", "MAT");
        Teacher t2 = new Teacher("Fatma Ayşe", "90550000001", "FZK");
        Teacher t3 = new Teacher("Ali Veli", "90550000002", "KMY");

        mat.addTeacher(t1);
        fizik.addTeacher(t2);
        kimya.addTeacher(t3);

        Student s1 = new Student("İnek Şaban", 4, "140144015", mat, fizik, kimya, smat, sfizik, skimya);
        s1.addBulkExamNote(50,20,40,50,95,75);
        s1.isPass();

        Student s2 = new Student("Güdük Necmi", 4, "2211133", mat, fizik, kimya, smat, sfizik, skimya);
        s2.addBulkExamNote(100,50,40,75,65,80);
        s2.isPass();

        Student s3 = new Student("Hayta İsmail", 4, "221121312", mat, fizik, kimya, smat, sfizik, skimya);
        s3.addBulkExamNote(50,20,40,55,70,85);
        s3.isPass();

    }
}