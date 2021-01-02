import { Directive, ElementRef, HostListener, Renderer2, Input, HostBinding } from '@angular/core';

@Directive({
  selector: '[appPurpleButton]'
})
export class PurpleButtonDirective {

  constructor(
    private elementRef: ElementRef,
    private renderer: Renderer2) { }

  ngOnInit() {
    this.color = this.defaultColor;
    this.renderer.setStyle(this.elementRef.nativeElement, 'background-color', this.defaultBackground);
  }

  @Input() defaultColor: string = 'white';
  @Input() highlight: string = '#b380ff';
  @Input() defaultBackground: string = '#b380ff';

  @HostBinding('style.color') color: string = this.defaultColor;

  @HostListener('mouseenter') mouseover() {
    this.renderer.setStyle(this.elementRef.nativeElement, 'background-color', '#eee');
    this.color = this.highlight;
  }

  @HostListener('mouseleave') mouseleave() {
    this.renderer.setStyle(this.elementRef.nativeElement, 'background-color', this.defaultBackground);
    this.color = this.defaultColor;
  }

}
