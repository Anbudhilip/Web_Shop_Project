<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="CAR_RENTAL_WEBSITE.Feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <br />
    <br />
    <br />
<br />
   
    <div class="mt-3">
    <div class="card  ">
        <div class="card-header p-3 text-center h-3">Feed Back Form</div>
        <div class="card-body">
<div class="mb-4">
    
  <label for="exampleFormControlInput1" class="form-label">Email address</label>
  <input type="email" class="form-control p-2" id="exampleFormControlInput1" placeholder="name@example.com">
</div>
<div class="mb-4">
 
  <textarea class="form-control" id="exampleFormControlTextarea1" placeholder=" write your query...." rows="7"></textarea>
</div>
            <div class="card-footer position-relative">
                <div class="btn btn-warning">Cancel</div>
                <div class=" btn btn-info  position-absolute top-50 end-0 translate-middle-y m">Submit</div>
                
            </div>
        </div>
        </div>
        </div>
</asp:Content>
