using api.Models.QLKHCanBo;
using System.Collections.Generic;



namespace QLCongViec.Components.ThongKe
{
    public interface IThongKeFilter
    {
        object Build(List<tbDeTaiKHCanBo> source);
    }
}
