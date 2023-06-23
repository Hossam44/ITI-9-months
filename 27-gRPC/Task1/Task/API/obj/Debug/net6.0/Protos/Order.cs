// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Order.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Inventory {

  /// <summary>Holder for reflection information generated from Protos/Order.proto</summary>
  public static partial class OrderReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/Order.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OrderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm90b3MvT3JkZXIucHJvdG8iZQoFT3JkZXISDwoHT3JkZXJJZBgBIAEo",
            "BRIaCghQcm9kdWN0cxgCIAMoCzIILlByb2R1Y3QSEgoKVG90YWxQcmljZRgD",
            "IAEoBRIbCghDdXN0b21lchgEIAEoCzIJLkN1c3RvbWVyIjQKCEN1c3RvbWVy",
            "EhIKCkN1c3RvbWVySWQYASABKAUSFAoMQ3VzdG9tZXJOYW1lGAIgASgJImMK",
            "B1Byb2R1Y3QSEQoJUHJvZHVjdElkGAEgASgFEhMKC1Byb2R1Y3ROYW1lGAIg",
            "ASgJEhoKElByb2R1Y3REZXNjcmlwdGlvbhgDIAEoCRIUCgxQcm9kdWN0UHJp",
            "Y2UYBCABKAUiKAoNT3JkZXJSZXNwb25zZRIXCg9SZXNwb25zZU1lc3NhZ2UY",
            "ASABKAgyMwoMT3JkZXJTZXJ2aWNlEiMKCU1ha2VPcmRlchIGLk9yZGVyGg4u",
            "T3JkZXJSZXNwb25zZUIMqgIJSW52ZW50b3J5YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Inventory.Order), global::Inventory.Order.Parser, new[]{ "OrderId", "Products", "TotalPrice", "Customer" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Inventory.Customer), global::Inventory.Customer.Parser, new[]{ "CustomerId", "CustomerName" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Inventory.Product), global::Inventory.Product.Parser, new[]{ "ProductId", "ProductName", "ProductDescription", "ProductPrice" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Inventory.OrderResponse), global::Inventory.OrderResponse.Parser, new[]{ "ResponseMessage" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Order : pb::IMessage<Order>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Order> _parser = new pb::MessageParser<Order>(() => new Order());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Order> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Inventory.OrderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Order() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Order(Order other) : this() {
      orderId_ = other.orderId_;
      products_ = other.products_.Clone();
      totalPrice_ = other.totalPrice_;
      customer_ = other.customer_ != null ? other.customer_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Order Clone() {
      return new Order(this);
    }

    /// <summary>Field number for the "OrderId" field.</summary>
    public const int OrderIdFieldNumber = 1;
    private int orderId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int OrderId {
      get { return orderId_; }
      set {
        orderId_ = value;
      }
    }

    /// <summary>Field number for the "Products" field.</summary>
    public const int ProductsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Inventory.Product> _repeated_products_codec
        = pb::FieldCodec.ForMessage(18, global::Inventory.Product.Parser);
    private readonly pbc::RepeatedField<global::Inventory.Product> products_ = new pbc::RepeatedField<global::Inventory.Product>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Inventory.Product> Products {
      get { return products_; }
    }

    /// <summary>Field number for the "TotalPrice" field.</summary>
    public const int TotalPriceFieldNumber = 3;
    private int totalPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int TotalPrice {
      get { return totalPrice_; }
      set {
        totalPrice_ = value;
      }
    }

    /// <summary>Field number for the "Customer" field.</summary>
    public const int CustomerFieldNumber = 4;
    private global::Inventory.Customer customer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Inventory.Customer Customer {
      get { return customer_; }
      set {
        customer_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Order);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Order other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OrderId != other.OrderId) return false;
      if(!products_.Equals(other.products_)) return false;
      if (TotalPrice != other.TotalPrice) return false;
      if (!object.Equals(Customer, other.Customer)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OrderId != 0) hash ^= OrderId.GetHashCode();
      hash ^= products_.GetHashCode();
      if (TotalPrice != 0) hash ^= TotalPrice.GetHashCode();
      if (customer_ != null) hash ^= Customer.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (OrderId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(OrderId);
      }
      products_.WriteTo(output, _repeated_products_codec);
      if (TotalPrice != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TotalPrice);
      }
      if (customer_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Customer);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (OrderId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(OrderId);
      }
      products_.WriteTo(ref output, _repeated_products_codec);
      if (TotalPrice != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TotalPrice);
      }
      if (customer_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Customer);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (OrderId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(OrderId);
      }
      size += products_.CalculateSize(_repeated_products_codec);
      if (TotalPrice != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TotalPrice);
      }
      if (customer_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Customer);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Order other) {
      if (other == null) {
        return;
      }
      if (other.OrderId != 0) {
        OrderId = other.OrderId;
      }
      products_.Add(other.products_);
      if (other.TotalPrice != 0) {
        TotalPrice = other.TotalPrice;
      }
      if (other.customer_ != null) {
        if (customer_ == null) {
          Customer = new global::Inventory.Customer();
        }
        Customer.MergeFrom(other.Customer);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            OrderId = input.ReadInt32();
            break;
          }
          case 18: {
            products_.AddEntriesFrom(input, _repeated_products_codec);
            break;
          }
          case 24: {
            TotalPrice = input.ReadInt32();
            break;
          }
          case 34: {
            if (customer_ == null) {
              Customer = new global::Inventory.Customer();
            }
            input.ReadMessage(Customer);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            OrderId = input.ReadInt32();
            break;
          }
          case 18: {
            products_.AddEntriesFrom(ref input, _repeated_products_codec);
            break;
          }
          case 24: {
            TotalPrice = input.ReadInt32();
            break;
          }
          case 34: {
            if (customer_ == null) {
              Customer = new global::Inventory.Customer();
            }
            input.ReadMessage(Customer);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Customer : pb::IMessage<Customer>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Customer> _parser = new pb::MessageParser<Customer>(() => new Customer());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Customer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Inventory.OrderReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Customer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Customer(Customer other) : this() {
      customerId_ = other.customerId_;
      customerName_ = other.customerName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Customer Clone() {
      return new Customer(this);
    }

    /// <summary>Field number for the "CustomerId" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private int customerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CustomerId {
      get { return customerId_; }
      set {
        customerId_ = value;
      }
    }

    /// <summary>Field number for the "CustomerName" field.</summary>
    public const int CustomerNameFieldNumber = 2;
    private string customerName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CustomerName {
      get { return customerName_; }
      set {
        customerName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Customer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Customer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if (CustomerName != other.CustomerName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId != 0) hash ^= CustomerId.GetHashCode();
      if (CustomerName.Length != 0) hash ^= CustomerName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (CustomerId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CustomerId);
      }
      if (CustomerName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CustomerName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CustomerId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CustomerId);
      }
      if (CustomerName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CustomerName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CustomerId);
      }
      if (CustomerName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Customer other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId != 0) {
        CustomerId = other.CustomerId;
      }
      if (other.CustomerName.Length != 0) {
        CustomerName = other.CustomerName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            CustomerId = input.ReadInt32();
            break;
          }
          case 18: {
            CustomerName = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            CustomerId = input.ReadInt32();
            break;
          }
          case 18: {
            CustomerName = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Product : pb::IMessage<Product>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Product> _parser = new pb::MessageParser<Product>(() => new Product());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Product> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Inventory.OrderReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Product() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Product(Product other) : this() {
      productId_ = other.productId_;
      productName_ = other.productName_;
      productDescription_ = other.productDescription_;
      productPrice_ = other.productPrice_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Product Clone() {
      return new Product(this);
    }

    /// <summary>Field number for the "ProductId" field.</summary>
    public const int ProductIdFieldNumber = 1;
    private int productId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ProductId {
      get { return productId_; }
      set {
        productId_ = value;
      }
    }

    /// <summary>Field number for the "ProductName" field.</summary>
    public const int ProductNameFieldNumber = 2;
    private string productName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProductName {
      get { return productName_; }
      set {
        productName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ProductDescription" field.</summary>
    public const int ProductDescriptionFieldNumber = 3;
    private string productDescription_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProductDescription {
      get { return productDescription_; }
      set {
        productDescription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ProductPrice" field.</summary>
    public const int ProductPriceFieldNumber = 4;
    private int productPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ProductPrice {
      get { return productPrice_; }
      set {
        productPrice_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Product);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Product other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProductId != other.ProductId) return false;
      if (ProductName != other.ProductName) return false;
      if (ProductDescription != other.ProductDescription) return false;
      if (ProductPrice != other.ProductPrice) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ProductId != 0) hash ^= ProductId.GetHashCode();
      if (ProductName.Length != 0) hash ^= ProductName.GetHashCode();
      if (ProductDescription.Length != 0) hash ^= ProductDescription.GetHashCode();
      if (ProductPrice != 0) hash ^= ProductPrice.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ProductId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ProductId);
      }
      if (ProductName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProductName);
      }
      if (ProductDescription.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProductDescription);
      }
      if (ProductPrice != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ProductPrice);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ProductId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ProductId);
      }
      if (ProductName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProductName);
      }
      if (ProductDescription.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProductDescription);
      }
      if (ProductPrice != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ProductPrice);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ProductId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ProductId);
      }
      if (ProductName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductName);
      }
      if (ProductDescription.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductDescription);
      }
      if (ProductPrice != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ProductPrice);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Product other) {
      if (other == null) {
        return;
      }
      if (other.ProductId != 0) {
        ProductId = other.ProductId;
      }
      if (other.ProductName.Length != 0) {
        ProductName = other.ProductName;
      }
      if (other.ProductDescription.Length != 0) {
        ProductDescription = other.ProductDescription;
      }
      if (other.ProductPrice != 0) {
        ProductPrice = other.ProductPrice;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ProductId = input.ReadInt32();
            break;
          }
          case 18: {
            ProductName = input.ReadString();
            break;
          }
          case 26: {
            ProductDescription = input.ReadString();
            break;
          }
          case 32: {
            ProductPrice = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ProductId = input.ReadInt32();
            break;
          }
          case 18: {
            ProductName = input.ReadString();
            break;
          }
          case 26: {
            ProductDescription = input.ReadString();
            break;
          }
          case 32: {
            ProductPrice = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class OrderResponse : pb::IMessage<OrderResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OrderResponse> _parser = new pb::MessageParser<OrderResponse>(() => new OrderResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OrderResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Inventory.OrderReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OrderResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OrderResponse(OrderResponse other) : this() {
      responseMessage_ = other.responseMessage_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OrderResponse Clone() {
      return new OrderResponse(this);
    }

    /// <summary>Field number for the "ResponseMessage" field.</summary>
    public const int ResponseMessageFieldNumber = 1;
    private bool responseMessage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ResponseMessage {
      get { return responseMessage_; }
      set {
        responseMessage_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OrderResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OrderResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResponseMessage != other.ResponseMessage) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResponseMessage != false) hash ^= ResponseMessage.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResponseMessage != false) {
        output.WriteRawTag(8);
        output.WriteBool(ResponseMessage);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResponseMessage != false) {
        output.WriteRawTag(8);
        output.WriteBool(ResponseMessage);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResponseMessage != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OrderResponse other) {
      if (other == null) {
        return;
      }
      if (other.ResponseMessage != false) {
        ResponseMessage = other.ResponseMessage;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ResponseMessage = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ResponseMessage = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
