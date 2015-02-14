using System.Collections.Generic;

namespace Shots.Api.Models
{
    public class BaseListResponse : BaseResponse
    {
        public List<ShotItem> Items { get; set; }
    }
}