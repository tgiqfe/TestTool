using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTool.Manifest.Result
{
    internal enum ReturnCodeRule
    {
        Equal,
        NotEqual,
        GreaterThan,
        LessThan,
        GreaterThanOrEqual,
        LessThanOrEqual,
        Range,
    }

    internal class ReturnCode
    {
        public string Code { get; set; }
        public string Description { get; set; }

        private int ReturnCodeValue { get; set; }

    }
}

/*
コマンド実行結果で戻り値が、
- 一致する
- 一致しない
- より大きい
- より小さい
- 以上
- 以下
- 範囲内
*/

