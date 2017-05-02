module internal Fable.Helpers.ReactGridSystem
open Fable.Core
open Fable.Import
open Fable.Import.React
open Fable.Core.JsInterop
open React.Props
open System

[<KeyValueList>]
type VisibleProps =
    | Xs of bool
    | Sm of bool
    | Md of bool
    | Lg of bool
    | Xl of bool
    
[<KeyValueList>]
type ShapeProps =
    | Xs of int
    | Sm of int
    | Md of int
    | Lg of int
    | Xl of int

[<KeyValueList>]
type ScreenClassRenderProps =
    | Style of Func<string,obj,CSSProp list>
    
[<KeyValueList>]
type ContainerProps =
    | Fluid of bool
    | Xs of bool
    | Sm of bool
    | Md of bool
    | Lg of bool
    | Xl of bool

[<KeyValueList>]
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

let Container = importMember<Fable.Import.React.ComponentClass<ContainerProps list>> "react-grid-system"
let inline container b c = Fable.Helpers.React.from Container b c

let Row = importMember<Fable.Import.React.ComponentClass<IHTMLProp list>> "react-grid-system"
let inline row b c = Fable.Helpers.React.from Row b c

let Col = importMember<Fable.Import.React.ComponentClass<ColProps list>> "react-grid-system"
let inline col b c = Fable.Helpers.React.from Col b c

let Visible = importMember<Fable.Import.React.ComponentClass<VisibleProps list>> "react-grid-system"
let inline visible b c = Fable.Helpers.React.from Visible b c

let Hidden = importMember<Fable.Import.React.ComponentClass<VisibleProps list>> "react-grid-system"
let inline hidden b c = Fable.Helpers.React.from Hidden b c

let ClearFix = importMember<Fable.Import.React.ComponentClass<VisibleProps list>> "react-grid-system"
let inline clearFix b c = Fable.Helpers.React.from ClearFix b c

let ScreenClassRender = importMember<Fable.Import.React.ComponentClass<ScreenClassRenderProps list>> "react-grid-system"
let inline screenClassRender b c = Fable.Helpers.React.from ScreenClassRender b c