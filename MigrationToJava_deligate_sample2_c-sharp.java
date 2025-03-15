import java.util.ArrayList;
import java.util.List;

public class SampleEx702 {

    // Actionインターフェースの定義
    interface Action {
        void execute(int a);
    }

    // 1つ目の処理
    static void func1(int a) {
        System.out.println("a=" + a);
    }

    // 2つ目の処理
    static void func2(int a) {
        System.out.println("a*2=" + (a * 2));
    }

    // 3つ目の処理
    static void func3(int a) {
        System.out.println("a*3=" + (a * 3));
    }

    public static void main(String[] args) {
        // Actionのリストを作成
        List<Action> actions = new ArrayList<>();

        // 処理の追加
        actions.add(SampleEx702::func1);
        actions.add(SampleEx702::func2);
        actions.add(SampleEx702::func3);

        // 処理の実行
        for (Action action : actions) {
            action.execute(3);
        }
    }
}
