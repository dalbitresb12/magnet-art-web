using si653ebu202015652.API.Shared.Extensions;

namespace si653ebu202015652.API.Shared.Domain.Model;

public class BaseModel {
  public int Id { get; set; }

  public void CopyProperties(BaseModel destination) {
    var ignoredKeys = new[] {"Id",};
    this.CopyProperties(destination, ignoredKeys);
  }
}
