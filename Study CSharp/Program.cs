using System;

namespace Study_CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ショートカット演算子();

        }

        void 配列()
        {
            //配列
            int[] numbers = {1, 2, 3};
        }

        static void 条件演算子()
        {
            var score = 75;
            Console.WriteLine(score >= 70 ? "合格！" : "不合格...");
        }

        static void null合体演算子()
        {
            string str = null;
            string def = "山田";
            Console.WriteLine(str ?? def);
            //strがnullだったらdefを出力する
        }
        /*論理演算子
         * && 論理積。左右の式がともにtrueの場合にtrue
         * || 論理和。左右の式いずれかがtrueの場合にtrue
         * ^  排他的論理和。左右の式いずれか一方だけがtrueの場合にtrue
         * !  否定。
         */
        static void ショートカット演算子()
        {
            string str = "http://";
            //＆＆や||は評価が確定した場合スキップ（ショートカット）する
            
            //StartWithは文字列が指定された文字列で始まるかを確認するためのメソッド
            
            if (str != null & str.StartsWith("http://"))
            {
                Console.WriteLine("あああ");
            }
            //&と&&の違い　&はショートカットをしない
        }
    }
}