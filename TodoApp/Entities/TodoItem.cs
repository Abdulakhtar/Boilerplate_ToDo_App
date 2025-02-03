using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace TodoApp.Entities;

public class TodoItem : BasicAggregateRoot<Guid>
{
    public string Text { get; set; }
}

