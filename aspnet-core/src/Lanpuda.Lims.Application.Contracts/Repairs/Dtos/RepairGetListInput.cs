using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace Lanpuda.Lims.Repairs.Dtos;

[Serializable]
public class RepairGetListInput : PagedAndSortedResultRequestDto
{
    /// <summary>
    /// 
    /// </summary>
    [DisplayName("RepairNumber")]
    public string? Number { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [DisplayName("RepairEquipmentId")]
    public Guid? EquipmentId { get; set; }
 
    /// <summary>
    /// 
    /// </summary>
    [DisplayName("RepairRepairDate")]
    public DateTime? RepairDate { get; set; }


    //ά�޽������¼ά�޵Ľ���������޸��ɹ��������޸����޷��޸��ȡ�
    public RepairResult? RepairResult { get; set; }

}