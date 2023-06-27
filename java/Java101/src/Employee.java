public class Employee {
    String name;
    double salary;
    int workHours;
    int hireYear;
    Employee (String name, double salary, int workHours, int hireYear) {
        this.name = name;
        this.salary = salary;
        this.workHours = workHours;
        this.hireYear = hireYear;
    }
    public double tax () {
        double tax = 0;
        if (salary > 1000) {
            tax += (salary * 3) / 100;
        }
        else {
            tax = 0;
        }
        return tax;
    }
    public double bonus () {
        double bonusFee ;
        if (workHours > 40) {
            bonusFee = (workHours - 40) * 30;
        }
        else {
            bonusFee = 0;
        }
        return bonusFee;
    }
    public double raiseSalary () {
        double increasedSalary = 0;
        if ((2021 - hireYear) < 10 ) {
            increasedSalary += (salary * 5) / 100;
        }
        if (((2021 - hireYear) > 9) && ((2021 - hireYear) < 20)) {
            increasedSalary += (salary * 10) / 100;
        }
        if ((2021 - hireYear) > 19) {
            increasedSalary += (salary * 15) / 100;
        }
        return increasedSalary;
    }
    public void sonuc() {
        System.out.println("Adı :" + this.name);
        System.out.println("Maaşı :" + this.salary);
        System.out.println("Çalışma Saati :" + this.workHours);
        System.out.println("Başlangıç Yılı : " + this.hireYear);
        System.out.println("Vergi : " + tax());
        System.out.println("Bonus : " + bonus());
        System.out.println("Maaş Artışı : " + raiseSalary());
        System.out.println("Vergi ve Bonuslar ile birlikte maaş : " + (salary + bonus() - tax()));
        System.out.println("Toplam Maaş : " + (salary +  raiseSalary()));
    }
    public static void main(String[] args) {
        Employee person1 = new Employee("Emine",9000,45,2012);
        Employee person2 = new Employee("Metin",8000,35,2010);
        person1.sonuc();
        person2.sonuc();
    }
}