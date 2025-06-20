
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//カードゲーム
namespace TrumpGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //カードの番号を4回入力させる
            for (int i = 0; i < 4; i++)
            {
                //一度の入力で、範囲内の値が入力されるまで繰り返す
                while (true)
                {
                    //カード番号の入力
                    Console.Write($"{i + 1}番目のカードを入力してください(1～4)　＞");


                    //入力内容のチェック
                    if (!int.TryParse(Console.ReadLine(), out int input))
                    {
                        //範囲外の値が入力されたら、エラー表示して再入力させる
                        Console.WriteLine("1～4の値を入力してください");
                        continue;
                    }

                    break;
                }
            }
        }
    }
}
