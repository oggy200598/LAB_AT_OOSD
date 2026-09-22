package Bt1;

import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        List<CHinhVe> danhSachHinh = new ArrayList<>();
        danhSachHinh.add(
            new CTamGiac(
                new CDiem(0, 0),
                new CDiem(4, 0),
                new CDiem(0, 3)
            )
        );
        danhSachHinh.add(
            new CTuGiac(
                new CDiem(0, 0),
                new CDiem(4, 0),
                new CDiem(4, 3),
                new CDiem(0, 3)
            )
        );
        danhSachHinh.add(
            new CEllipse(
                new CDiem(0, 0),
                5,
                3
            )
        );
        System.out.println(
            "=== KET QUA XU LY DA HINH ==="
        );
        for (CHinhVe hinh : danhSachHinh) {
            hinh.ve();

            System.out.printf(
                "Chu vi: %.2f\n",
                hinh.chuVi()
            );
            System.out.printf(
                "Dien tich: %.2f\n",
                hinh.dienTich()
            );
            System.out.println(
                "----------------------------------------"
            );
        }
    }
}
// Lop CDiem
class CDiem {
    private float x;
    private float y;

    public CDiem() {
        this.x = 0;
        this.y = 0;
    }
    public CDiem(float x, float y) {
        this.x = x;
        this.y = y;
    }
    public float getX() {
        return x;
    }
    public float getY() {
        return y;
    }
    public float khoangCach(CDiem d) {
        return (float) Math.sqrt(
            Math.pow(this.x - d.x, 2) +
            Math.pow(this.y - d.y, 2)
        );
    }
}
// Lop cha CHinhVe
class CHinhVe {
    protected int maLoaiHinhVe;
    public CHinhVe() {
        maLoaiHinhVe = 0;
    }
    public CHinhVe(int maLoaiHinhVe) {
        this.maLoaiHinhVe = maLoaiHinhVe;
    }
    public float dienTich() {
        return 0;
    }
    public float chuVi() {
        return 0;
    }
    public void ve() {
        System.out.println("Ve hinh ve chung");
    }
}
// Lop CTamGiac
class CTamGiac extends CHinhVe {
    protected CDiem p1;
    protected CDiem p2;
    protected CDiem p3;
    public CTamGiac() {
        super(1);
        p1 = new CDiem(0, 0);
        p2 = new CDiem(1, 0);
        p3 = new CDiem(0, 1);
    }
    public CTamGiac(CDiem p1, CDiem p2, CDiem p3) {
        super(1);

        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
    }
    @Override
    public float chuVi() {
        float a = p1.khoangCach(p2);
        float b = p2.khoangCach(p3);
        float c = p3.khoangCach(p1);

        return a + b + c;
    }
    @Override
    public float dienTich() {
        float p = chuVi() / 2;

        float a = p1.khoangCach(p2);
        float b = p2.khoangCach(p3);
        float c = p3.khoangCach(p1);

        return (float) Math.sqrt(
            p * (p - a) * (p - b) * (p - c)
        );
    }
    @Override
    public void ve() {
        System.out.println(
            "Dang ve Hinh Tam Giac qua 3 diem P1, P2, P3."
        );
    }
}
// Lop CTuGiac
class CTuGiac extends CHinhVe {
    protected CDiem p1;
    protected CDiem p2;
    protected CDiem p3;
    protected CDiem p4;
    public CTuGiac(
        CDiem p1,
        CDiem p2,
        CDiem p3,
        CDiem p4
    ) {
        super(2);

        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
        this.p4 = p4;
    }
    @Override
    public float chuVi() {
        return p1.khoangCach(p2)
            + p2.khoangCach(p3)
            + p3.khoangCach(p4)
            + p4.khoangCach(p1);
    }
    @Override
    public float dienTich() {
        CTamGiac tg1 =
            new CTamGiac(p1, p2, p3);

        CTamGiac tg2 =
            new CTamGiac(p1, p3, p4);

        return tg1.dienTich()
            + tg2.dienTich();
    }
    @Override
    public void ve() {
        System.out.println(
            "Dang ve Hinh Tu Giac qua 4 diem P1, P2, P3, P4."
        );
    }
}
// Lop CEllipse
class CEllipse extends CHinhVe {
    protected CDiem diemTam;
    protected float floatA;
    protected float floatB;
    public CEllipse(
        CDiem diemTam,
        float floatA,
        float floatB
    ) {
        super(3);
        this.diemTam = diemTam;
        this.floatA = floatA;
        this.floatB = floatB;
    }
    @Override
    public float dienTich() {
        return (float)
            (Math.PI * floatA * floatB);
    }
    @Override
    public float chuVi() {
        return (float) (
            Math.PI *
            (
                3 * (floatA + floatB)
                - Math.sqrt(
                    (3 * floatA + floatB)
                    * (floatA + 3 * floatB)
                )
            )
        );
    }
    @Override
    public void ve() {
        System.out.println(
            "Dang ve Hinh Ellipse voi ban truc A = "
            + floatA + ", B = " + floatB
        );
    }
}