using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenTool.ViewModels
{
    [RegionMemberLifetime(KeepAlive = false)]
    class CadenBaseGeneControlViewModel : BindableBase
    {
        public DelegateCommand PullOriginDataFromYQ { get; private set; }
        public DelegateCommand GeneLocalBlogData { get; private set; }
        public DelegateCommand GeneWpBlogData { get; private set; }
        public CadenBaseGeneControlViewModel()
        {
            // 初始化命令，并指定执行方法
            PullOriginDataFromYQ = new DelegateCommand(ExecutePullOriginDataFromYQ);
            GeneLocalBlogData = new DelegateCommand(ExecuteGeneLocalBlogData);
            GeneWpBlogData = new DelegateCommand(ExecuteGeneWpBlogData);
        }

        // 执行方法
        private void ExecutePullOriginDataFromYQ()
        {
            // 处理拉取语雀云端数据的逻辑
            // 例如调用服务从云端拉取数据
        }

        private void ExecuteGeneLocalBlogData()
        {
            // 处理生成本地博客的逻辑
        }

        private void ExecuteGeneWpBlogData()
        {
            // 处理生成本地博客的逻辑
        }
    }
}
