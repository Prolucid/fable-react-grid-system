module Fable.Helpers.ReactGridSystem
open Fable.Core
open Fable.Import
open Fable.Import.React
open Fable.Core.JsInterop
open React.Props
open System

type IRGProp = inherit IHTMLProp

type VisibleProps =
    | Xs of bool
    | Sm of bool
    | Md of bool
    | Lg of bool
    | Xl of bool
    interface IRGProp  
    
type ShapeProps =
    | Xs of int
    | Sm of int
    | Md of int
    | Lg of int
    | Xl of int
    interface IRGProp  
    
type ScreenClassRenderProps =
    | Style of Func<string,obj,CSSProp list>
    interface IRGProp  
    
type ContainerProps =
    | Fluid of bool
    | Xs of bool
    | Sm of bool
    | Md of bool
    | Lg of bool
    | Xl of bool
    interface IRGProp  
    
type ColProps =
    | Xs of int
    | Sm of int
    | Md of int
    | Lg of int
    | Xl of int
    | Debug of bool
    | Offset of ShapeProps list
    | Push of ShapeProps list
    | Pull of ShapeProps list
    interface IRGProp  

let inline rgsEl<'P when 'P :> IHTMLProp> (a:ComponentClass<'P>) (b:IHTMLProp list) c = Fable.Helpers.React.from a (keyValueList CaseRules.LowerFirst b |> unbox) c

let Container = importMember<Fable.Import.React.ComponentClass<IHTMLProp>> "react-grid-system"
let inline container b c = rgsEl Container b c

let Row = importMember<Fable.Import.React.ComponentClass<IHTMLProp>> "react-grid-system"
let inline row b c = rgsEl Row b c

let Col = importMember<Fable.Import.React.ComponentClass<IHTMLProp>> "react-grid-system"
let inline col b c = rgsEl Col b c

let Visible = importMember<Fable.Import.React.ComponentClass<IHTMLProp>> "react-grid-system"
let inline visible b c = rgsEl Visible b c

let Hidden = importMember<Fable.Import.React.ComponentClass<IHTMLProp>> "react-grid-system"
let inline hidden b c = rgsEl Hidden b c

let ClearFix = importMember<Fable.Import.React.ComponentClass<IHTMLProp>> "react-grid-system"
let inline clearFix b c = rgsEl ClearFix b c

let ScreenClassRender = importMember<Fable.Import.React.ComponentClass<IHTMLProp>> "react-grid-system"
let inline screenClassRender b c = rgsEl ScreenClassRender b c