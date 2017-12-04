# MAX-SUBSET-PDP  

* Instance: A multiset multiset of K positive integers D = {d1, ..., dk}.  
* Solution: A set of M non-negative integers P = {p1, ..., pm} such that {|pi − pj|: 1 ≤ i < j ≤ m} ⊆ D and m are the maximum.  
  
  setup  
  * supportedRuntime version: 4.0  
  * .NETFramework: v4.5  
  dependencies:  
  * MetroModernUI.1.4.0.0 (framework) 
  

### Instance generator: ###
Main data structure: List<>  
Displayed at:  DrawGridView  
Save to: file.csv (grandparent directory _MAX-SUBSET-PDP\ZP_Max_PDP\Instance_)  
Pessimistic computational complexity: O(n2)  

### Read from file  
CSV files  
With mistakes  

### Preliminary algorithm  
Hill-Climbing algorithm with restarts parameter  

### Main algorithm  
Tabu Search implementation with preliminary solution from hill-climbing  
  
  parameters to change:
  * restarts number
  * iterations number
  * size of the tabu list 
  * cadency
