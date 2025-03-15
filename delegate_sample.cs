using System;

namespace DelegateExample
{
    // デリゲートの定義
    public delegate void MyDelegate();

    public class MyClass
    {
        private MyDelegate _delegate;

        // デリゲートを設定するメソッド
        public void SetDelegate(MyDelegate del)
        {
            _delegate = del;
        }

        // アクションを実行するメソッド
        public void PerformAction()
        {
            _delegate?.Invoke(); // デリゲートが設定されていれば実行
        }
    }

    // 具体的なデリゲートの実装
    public class MyConcreteDelegate
    {
        public void DoSomething()
        {
            Console.WriteLine("具体的な処理を実行します！");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            MyClass myObject = new MyClass();
            MyConcreteDelegate concreteDelegate = new MyConcreteDelegate();

            // デリゲートを設定
            myObject.SetDelegate(concreteDelegate.DoSomething);
            myObject.PerformAction(); // 出力: 具体的な処理を実行します！
        }
    }
}
