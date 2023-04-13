﻿using TEngine;
using ProcedureOwner = TEngine.IFsm<TEngine.IProcedureManager>;

namespace GameMain
{
    public class ProcedureDownloadOver:ProcedureBase
    {
        public override bool UseNativeDialog { get; }

        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            Log.Info("下载完成!!!");
            
            UILoadMgr.Show(UIDefine.UILoadUpdate,$"下载完成...");
        }

        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            ChangeState<ProcedureClearCache>(procedureOwner);
        }
    }
}