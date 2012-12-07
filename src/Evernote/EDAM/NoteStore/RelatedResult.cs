/**
 * Autogenerated by Thrift
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Evernote.EDAM.NoteStore
{

  #if !SILVERLIGHT && !NETFX_CORE
  [Serializable]
  #endif
  public partial class RelatedResult : TBase
  {
    private List<Evernote.EDAM.Type.Note> _notes;
    private List<Evernote.EDAM.Type.Notebook> _notebooks;
    private List<Evernote.EDAM.Type.Tag> _tags;
    private List<Evernote.EDAM.Type.NotebookDescriptor> _containingNotebooks;
    private string _debugInfo;

    public List<Evernote.EDAM.Type.Note> Notes
    {
      get
      {
        return _notes;
      }
      set
      {
        __isset.notes = true;
        this._notes = value;
      }
    }

    public List<Evernote.EDAM.Type.Notebook> Notebooks
    {
      get
      {
        return _notebooks;
      }
      set
      {
        __isset.notebooks = true;
        this._notebooks = value;
      }
    }

    public List<Evernote.EDAM.Type.Tag> Tags
    {
      get
      {
        return _tags;
      }
      set
      {
        __isset.tags = true;
        this._tags = value;
      }
    }

    public List<Evernote.EDAM.Type.NotebookDescriptor> ContainingNotebooks
    {
      get
      {
        return _containingNotebooks;
      }
      set
      {
        __isset.containingNotebooks = true;
        this._containingNotebooks = value;
      }
    }

    public string DebugInfo
    {
      get
      {
        return _debugInfo;
      }
      set
      {
        __isset.debugInfo = true;
        this._debugInfo = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT && !NETFX_CORE
    [Serializable]
    #endif
    public struct Isset {
      public bool notes;
      public bool notebooks;
      public bool tags;
      public bool containingNotebooks;
      public bool debugInfo;
    }

    public RelatedResult() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.List) {
              {
                Notes = new List<Evernote.EDAM.Type.Note>();
                TList _list94 = iprot.ReadListBegin();
                for( int _i95 = 0; _i95 < _list94.Count; ++_i95)
                {
                  Evernote.EDAM.Type.Note _elem96 = new Evernote.EDAM.Type.Note();
                  _elem96 = new Evernote.EDAM.Type.Note();
                  _elem96.Read(iprot);
                  Notes.Add(_elem96);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                Notebooks = new List<Evernote.EDAM.Type.Notebook>();
                TList _list97 = iprot.ReadListBegin();
                for( int _i98 = 0; _i98 < _list97.Count; ++_i98)
                {
                  Evernote.EDAM.Type.Notebook _elem99 = new Evernote.EDAM.Type.Notebook();
                  _elem99 = new Evernote.EDAM.Type.Notebook();
                  _elem99.Read(iprot);
                  Notebooks.Add(_elem99);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.List) {
              {
                Tags = new List<Evernote.EDAM.Type.Tag>();
                TList _list100 = iprot.ReadListBegin();
                for( int _i101 = 0; _i101 < _list100.Count; ++_i101)
                {
                  Evernote.EDAM.Type.Tag _elem102 = new Evernote.EDAM.Type.Tag();
                  _elem102 = new Evernote.EDAM.Type.Tag();
                  _elem102.Read(iprot);
                  Tags.Add(_elem102);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                ContainingNotebooks = new List<Evernote.EDAM.Type.NotebookDescriptor>();
                TList _list103 = iprot.ReadListBegin();
                for( int _i104 = 0; _i104 < _list103.Count; ++_i104)
                {
                  Evernote.EDAM.Type.NotebookDescriptor _elem105 = new Evernote.EDAM.Type.NotebookDescriptor();
                  _elem105 = new Evernote.EDAM.Type.NotebookDescriptor();
                  _elem105.Read(iprot);
                  ContainingNotebooks.Add(_elem105);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              DebugInfo = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("RelatedResult");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Notes != null && __isset.notes) {
        field.Name = "notes";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Notes.Count));
          foreach (Evernote.EDAM.Type.Note _iter106 in Notes)
          {
            _iter106.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (Notebooks != null && __isset.notebooks) {
        field.Name = "notebooks";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Notebooks.Count));
          foreach (Evernote.EDAM.Type.Notebook _iter107 in Notebooks)
          {
            _iter107.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (Tags != null && __isset.tags) {
        field.Name = "tags";
        field.Type = TType.List;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Tags.Count));
          foreach (Evernote.EDAM.Type.Tag _iter108 in Tags)
          {
            _iter108.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (ContainingNotebooks != null && __isset.containingNotebooks) {
        field.Name = "containingNotebooks";
        field.Type = TType.List;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ContainingNotebooks.Count));
          foreach (Evernote.EDAM.Type.NotebookDescriptor _iter109 in ContainingNotebooks)
          {
            _iter109.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (DebugInfo != null && __isset.debugInfo) {
        field.Name = "debugInfo";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(DebugInfo);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("RelatedResult(");
      sb.Append("Notes: ");
      sb.Append(Notes);
      sb.Append(",Notebooks: ");
      sb.Append(Notebooks);
      sb.Append(",Tags: ");
      sb.Append(Tags);
      sb.Append(",ContainingNotebooks: ");
      sb.Append(ContainingNotebooks);
      sb.Append(",DebugInfo: ");
      sb.Append(DebugInfo);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
